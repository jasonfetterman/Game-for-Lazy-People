using System.Collections;
using Game.Interaction;
using UnityEngine;

namespace Game.Tasks
{
    [DisallowMultipleComponent]
    public sealed class DishwasherAutomation : MonoBehaviour, IInteractable
    {
        private const string OwnershipKey = "GameForLazyPeople_DishwasherOwned";

        [Header("Purchase")]
        [SerializeField, Min(1)] private int purchasePrice = 75;

        [Header("Automation")]
        [SerializeField, Min(1f)] private float cleaningDelay = 10f;

        private Game.Economy.PlayerWallet wallet;
        private HouseholdTask targetTask;
        private bool purchased;
        private bool cleaning;

        public string InteractionName => "Automatic Dishwasher";

        public string InteractionPrompt
        {
            get
            {
                if (purchased)
                    return cleaning
                        ? "Dishwasher is cleaning..."
                        : "Dishwasher owned";

                return wallet != null && wallet.CanAfford(purchasePrice)
                    ? $"Press E to buy dishwasher (${purchasePrice})"
                    : $"Dishwasher costs ${purchasePrice}";
            }
        }

        public bool CanInteract =>
            !purchased && wallet != null && targetTask != null &&
            !targetTask.IsCompleted;

        private void Awake()
        {
            purchased = PlayerPrefs.GetInt(OwnershipKey, 0) == 1;

            GameObject player = GameObject.Find("PLAYER_INSTANCE");

            if (player != null)
                wallet = player.GetComponent<Game.Economy.PlayerWallet>();

            targetTask = FindFirstObjectByType<HouseholdTask>();
        }

        public void Interact()
        {
            if (!CanInteract)
                return;

            if (!wallet.Spend(purchasePrice))
                return;

            purchased = true;

            PlayerPrefs.SetInt(OwnershipKey, 1);
            PlayerPrefs.Save();

            cleaning = true;

            Debug.Log(
                $"Dishwasher purchased for ${purchasePrice}. Ownership saved.");

            StartCoroutine(CleaningRoutine());
        }

        private IEnumerator CleaningRoutine()
        {
            yield return new WaitForSeconds(cleaningDelay);

            if (targetTask != null && !targetTask.IsCompleted)
            {
                if (targetTask.Complete())
                {
                    targetTask.gameObject.SetActive(false);
                    Debug.Log("Dishwasher finished cleaning. $25 earned automatically.");
                }
            }

            cleaning = false;
        }
    }
}

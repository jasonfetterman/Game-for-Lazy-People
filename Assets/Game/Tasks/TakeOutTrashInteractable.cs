using UnityEngine;
using Game.Interaction;
using Game.Economy;

namespace Game.Tasks
{
    public class TakeOutTrashInteractable : MonoBehaviour, IInteractable
    {
        [Header("Task Settings")]
        [SerializeField] private string taskName = "Take Out Trash";
        [SerializeField] private int reward = 25;

        [Header("Interaction")]
        [SerializeField] private string interactionPrompt =
            "Press E to take out trash (+$25)";

        [Header("Completion")]
        [SerializeField] private bool disableAfterCompletion = true;

        private PlayerWallet wallet;
        private bool completed;

        public string InteractionName => taskName;
        public string InteractionPrompt => completed ? string.Empty : interactionPrompt;
        public bool CanInteract => !completed && wallet != null;

        private void Awake()
        {
            GameObject player = GameObject.Find("PLAYER_INSTANCE");

            if (player != null)
                wallet = player.GetComponent<PlayerWallet>();

            if (wallet == null)
                Debug.LogError("Take Out Trash: PlayerWallet could not be found.");
        }

        public void Interact()
        {
            if (!CanInteract)
                return;

            completed = true;
            wallet.Earn(reward);

            Debug.Log($"Task completed: {taskName}. Earned ${reward}.");

            if (disableAfterCompletion)
                gameObject.SetActive(false);
        }
    }
}

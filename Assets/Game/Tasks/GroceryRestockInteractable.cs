using Game.Economy;
using Game.Interaction;
using UnityEngine;

namespace Game.Tasks
{
    [DisallowMultipleComponent]
    public sealed class GroceryRestockInteractable : MonoBehaviour, IInteractable
    {
        [SerializeField] private RefrigeratorInteractable refrigerator;
        [SerializeField] private PlayerWallet wallet;
        [SerializeField, Min(1)] private int purchasePrice = 20;
        [SerializeField, Min(1)] private int foodAmount = 5;

        public string InteractionName => "Grocery Restock";

        public string InteractionPrompt =>
            wallet != null && wallet.CanAfford(purchasePrice)
                ? $"Press E to buy {foodAmount} food (${purchasePrice})"
                : $"Need ${purchasePrice} for groceries";

        public bool CanInteract =>
            refrigerator != null && wallet != null;

        private void Awake()
        {
            if (wallet == null)
            {
                GameObject player = GameObject.Find("PLAYER_INSTANCE");

                if (player != null)
                    wallet = player.GetComponent<PlayerWallet>();
            }
        }

        public void Interact()
        {
            if (!CanInteract)
                return;

            if (!wallet.CanAfford(purchasePrice))
            {
                Debug.Log("Not enough money to buy groceries.");
                return;
            }

            if (!wallet.Spend(purchasePrice))
                return;

            if (!refrigerator.RestockFood(foodAmount))
            {
                wallet.Earn(purchasePrice);
                Debug.LogError("Grocery restock failed. Purchase refunded.");
                return;
            }

            Debug.Log(
                $"Groceries purchased: {foodAmount} food for ${purchasePrice}.");
        }
    }
}

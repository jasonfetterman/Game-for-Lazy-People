using Game.Inventory;
using TMPro;
using UnityEngine;

namespace Game.UI
{
    [DisallowMultipleComponent]
    public sealed class FoodInventoryUI : MonoBehaviour
    {
        [SerializeField] private PlayerInventory inventory;
        [SerializeField] private TextMeshProUGUI foodCountText;

        private const string FoodItemId = "food.basic";

        private void Awake()
        {
            if (inventory == null)
                inventory = FindFirstObjectByType<PlayerInventory>();
        }

        private void OnEnable()
        {
            if (inventory != null)
                inventory.InventoryChanged += HandleInventoryChanged;

            Refresh();
        }

        private void OnDisable()
        {
            if (inventory != null)
                inventory.InventoryChanged -= HandleInventoryChanged;
        }

        private void HandleInventoryChanged(string itemId, int quantity)
        {
            if (itemId == FoodItemId)
                Refresh();
        }

        private void Refresh()
        {
            if (foodCountText == null)
                return;

            int quantity = inventory != null
                ? inventory.GetQuantity(FoodItemId)
                : 0;

            foodCountText.text = "FOOD  " + quantity.ToString("D2");
        }
    }
}

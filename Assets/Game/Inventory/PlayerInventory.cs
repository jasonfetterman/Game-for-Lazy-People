using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Inventory
{
    [DisallowMultipleComponent]
    public sealed class PlayerInventory : MonoBehaviour
    {
        private readonly Dictionary<string, int> items =
            new Dictionary<string, int>(StringComparer.Ordinal);

        public event Action<string, int> InventoryChanged;

        public int GetQuantity(string itemId)
        {
            if (string.IsNullOrWhiteSpace(itemId))
                return 0;

            return items.TryGetValue(itemId, out int quantity)
                ? quantity
                : 0;
        }

        public bool AddItem(string itemId, int quantity = 1)
        {
            if (string.IsNullOrWhiteSpace(itemId) || quantity <= 0)
                return false;

            int newQuantity = GetQuantity(itemId) + quantity;
            items[itemId] = newQuantity;

            InventoryChanged?.Invoke(itemId, newQuantity);
            return true;
        }

        public bool RemoveItem(string itemId, int quantity = 1)
        {
            if (string.IsNullOrWhiteSpace(itemId) || quantity <= 0)
                return false;

            int currentQuantity = GetQuantity(itemId);

            if (currentQuantity < quantity)
                return false;

            int newQuantity = currentQuantity - quantity;

            if (newQuantity == 0)
                items.Remove(itemId);
            else
                items[itemId] = newQuantity;

            InventoryChanged?.Invoke(itemId, newQuantity);
            return true;
        }

        public IReadOnlyDictionary<string, int> GetItems()
        {
            return items;
        }
    }
}

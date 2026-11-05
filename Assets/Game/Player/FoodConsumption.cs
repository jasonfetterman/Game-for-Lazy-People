using Game.Inventory;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Game.Player
{
    [DisallowMultipleComponent]
    public sealed class FoodConsumption : MonoBehaviour
    {
        private const string FoodItemId = "food.basic";
        private const float HungerRestoration = 25f;

        [SerializeField] private PlayerInventory inventory;
        [SerializeField] private HungerSystem hunger;

        private InputAction eatAction;

        private void Awake()
        {
            if (inventory == null)
                inventory = GetComponent<PlayerInventory>();

            if (hunger == null)
                hunger = GetComponent<HungerSystem>();

            eatAction = new InputAction(
                "Eat Food",
                InputActionType.Button,
                "<Keyboard>/f");

            eatAction.AddBinding("<Gamepad>/buttonNorth");
        }

        private void OnEnable()
        {
            eatAction?.Enable();
        }

        private void OnDisable()
        {
            eatAction?.Disable();
        }

        private void Update()
        {
            if (eatAction.WasPressedThisFrame())
                TryEatFood();
        }

        public bool TryEatFood()
        {
            if (inventory == null || hunger == null)
                return false;

            if (hunger.CurrentHunger >= hunger.MaximumHunger)
            {
                Debug.Log("You are not hungry yet.");
                return false;
            }

            if (!inventory.RemoveItem(FoodItemId, 1))
            {
                Debug.Log("You have no food to eat.");
                return false;
            }

            hunger.RestoreHunger(HungerRestoration);

            Debug.Log(
                $"Food eaten. Hunger restored by {HungerRestoration}. Current hunger: {hunger.CurrentHunger:F1}%");

            return true;
        }

        private void OnDestroy()
        {
            eatAction?.Dispose();
        }
    }
}

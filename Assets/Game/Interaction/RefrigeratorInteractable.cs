using System.Collections;
using UnityEngine;
using Game.Inventory;

namespace Game.Interaction
{
    [DisallowMultipleComponent]
    public sealed class RefrigeratorInteractable : MonoBehaviour, IInteractable
    {
        private const string FoodItemId = "food.basic";

        [Header("Door")]
        [SerializeField] private Transform door;
        [SerializeField] private Vector3 closedLocalEulerAngles;
        [SerializeField] private Vector3 openLocalEulerAngles =
            new Vector3(0f, -110f, 0f);

        [Header("Food Supply")]
        [SerializeField, Min(0)] private int foodSupply = 5;

        [Header("Animation")]
        [SerializeField, Min(0.05f)] private float animationDuration = 0.45f;

        private Coroutine doorAnimation;
        private PlayerInventory playerInventory;
        private bool isOpen;
        private bool collectedThisVisit;

        public string InteractionName => "Refrigerator";

        public string InteractionPrompt
        {
            get
            {
                if (!isOpen)
                    return "Open refrigerator";

                return collectedThisVisit || foodSupply <= 0
                    ? "Close refrigerator"
                    : "Collect food";
            }
        }

        public bool CanInteract => door != null && doorAnimation == null;

        public bool IsOpen => isOpen;
        public int RemainingFood => foodSupply;

        public bool RestockFood(int amount)
        {
            if (amount <= 0)
                return false;

            foodSupply += amount;

            Debug.Log(
                $"Refrigerator restocked with {amount} food. Total supply: {foodSupply}");

            return true;
        }

        private void Awake()
        {
            if (door == null)
                door = transform.Find("Door");

            if (door != null)
                door.localRotation =
                    Quaternion.Euler(closedLocalEulerAngles);

            playerInventory =
                FindFirstObjectByType<PlayerInventory>();
        }

        public void Interact()
        {
            if (!CanInteract)
                return;

            if (!isOpen)
            {
                isOpen = true;
                collectedThisVisit = false;
                AnimateDoor(openLocalEulerAngles);
                return;
            }

            if (!collectedThisVisit &&
                foodSupply > 0 &&
                playerInventory != null)
            {
                if (playerInventory.AddItem(FoodItemId, 1))
                {
                    foodSupply--;
                    collectedThisVisit = true;

                    Debug.Log(
                        $"Food collected. Remaining refrigerator supply: {foodSupply}");
                    return;
                }
            }

            isOpen = false;
            collectedThisVisit = false;
            AnimateDoor(closedLocalEulerAngles);
        }

        private void AnimateDoor(Vector3 targetAngles)
        {
            Quaternion targetRotation =
                Quaternion.Euler(targetAngles);

            doorAnimation =
                StartCoroutine(AnimateDoorRoutine(targetRotation));
        }

        private IEnumerator AnimateDoorRoutine(
            Quaternion targetRotation)
        {
            Quaternion startingRotation = door.localRotation;
            float elapsed = 0f;

            while (elapsed < animationDuration)
            {
                elapsed += Time.deltaTime;

                float progress =
                    Mathf.Clamp01(elapsed / animationDuration);

                float easedProgress =
                    progress * progress * (3f - 2f * progress);

                door.localRotation = Quaternion.Slerp(
                    startingRotation,
                    targetRotation,
                    easedProgress);

                yield return null;
            }

            door.localRotation = targetRotation;
            doorAnimation = null;
        }

        private void OnValidate()
        {
            foodSupply = Mathf.Max(0, foodSupply);
            animationDuration = Mathf.Max(0.05f, animationDuration);
        }
    }
}


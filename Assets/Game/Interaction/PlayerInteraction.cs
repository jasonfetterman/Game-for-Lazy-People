using UnityEngine;
using UnityEngine.InputSystem;
using System;

namespace Game.Interaction
{
    [DisallowMultipleComponent]
    public sealed class PlayerInteraction : MonoBehaviour
    {
        [Header("Proximity Detection")]
        [SerializeField, Min(0.5f)] private float interactionDistance = 3f;
        [SerializeField] private LayerMask interactionLayers = ~0;

        private IInteractable currentInteractable;
        private InputAction interactAction;

        public IInteractable CurrentInteractable => currentInteractable;

        public event Action<IInteractable> TargetChanged;

        private void Awake()
        {
            interactAction = new InputAction(
                "Interact",
                InputActionType.Button,
                "<Keyboard>/e");

            interactAction.AddBinding("<Gamepad>/buttonWest");
        }

        private void OnEnable()
        {
            interactAction?.Enable();
        }

        private void OnDisable()
        {
            interactAction?.Disable();
            SetCurrentInteractable(null);
        }

        private void Update()
        {
            DetectNearbyInteractable();

            if (interactAction.WasPressedThisFrame() &&
                currentInteractable != null &&
                currentInteractable.CanInteract)
            {
                currentInteractable.Interact();
            }
        }

        private void DetectNearbyInteractable()
        {
            IInteractable nearest = null;
            float nearestDistance = interactionDistance;

            Collider[] nearbyColliders = Physics.OverlapSphere(
                transform.position,
                interactionDistance,
                interactionLayers,
                QueryTriggerInteraction.Ignore);

            foreach (Collider nearbyCollider in nearbyColliders)
            {
                if (nearbyCollider.transform == transform ||
                    nearbyCollider.transform.IsChildOf(transform))
                    continue;

                MonoBehaviour[] behaviours =
                    nearbyCollider.GetComponentsInParent<MonoBehaviour>();

                foreach (MonoBehaviour behaviour in behaviours)
                {
                    if (!(behaviour is IInteractable interactable) ||
                        !interactable.CanInteract)
                        continue;

                    Vector3 closestPoint =
                        nearbyCollider.ClosestPoint(transform.position);

                    float distance =
                        Vector3.Distance(transform.position, closestPoint);

                    if (distance < nearestDistance)
                    {
                        nearestDistance = distance;
                        nearest = interactable;
                    }
                }
            }

            SetCurrentInteractable(nearest);
        }

        private void SetCurrentInteractable(IInteractable interactable)
        {
            if (ReferenceEquals(currentInteractable, interactable))
                return;

            currentInteractable = interactable;
            TargetChanged?.Invoke(currentInteractable);
        }

        private void OnDestroy()
        {
            interactAction?.Dispose();
        }

        private void OnValidate()
        {
            interactionDistance = Mathf.Max(0.5f, interactionDistance);
        }
    }
}

using Game.Interaction;
using UnityEngine;

namespace Game.Tasks
{
    [DisallowMultipleComponent]
    public sealed class CleaningTaskInteractable : MonoBehaviour, IInteractable
    {
        [SerializeField] private HouseholdTask householdTask;
        [SerializeField] private string interactionName = "Dirty Dishes";
        [SerializeField] private string interactionPrompt =
            "Press E to clean dishes (+$25)";

        public string InteractionName => interactionName;
        public string InteractionPrompt =>
            householdTask != null && householdTask.IsCompleted
                ? "Dishes are already clean"
                : interactionPrompt;

        public bool CanInteract =>
            householdTask != null && !householdTask.IsCompleted;

        public void Interact()
        {
            if (householdTask == null || householdTask.IsCompleted)
                return;

            if (householdTask.Complete())
            {
                gameObject.SetActive(false);
            }
        }
    }
}

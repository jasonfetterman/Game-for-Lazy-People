using TMPro;
using UnityEngine;

namespace Game.Interaction
{
    [DisallowMultipleComponent]
    public sealed class InteractionPromptUI : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private PlayerInteraction playerInteraction;
        [SerializeField] private TextMeshProUGUI promptText;

        private GameObject promptRoot;

        private void Awake()
        {
            if (promptText != null && promptText.transform.parent != null)
                promptRoot = promptText.transform.parent.gameObject;
        }

        private void OnEnable()
        {
            if (playerInteraction != null)
                playerInteraction.TargetChanged += HandleTargetChanged;

            RefreshPrompt();
        }

        private void OnDisable()
        {
            if (playerInteraction != null)
                playerInteraction.TargetChanged -= HandleTargetChanged;
        }

        private void Update()
        {
            RefreshPrompt();
        }

        private void HandleTargetChanged(IInteractable target)
        {
            RefreshPrompt();
        }

        private void RefreshPrompt()
        {
            if (promptText == null || promptRoot == null)
                return;

            IInteractable target = playerInteraction != null
                ? playerInteraction.CurrentInteractable
                : null;

            bool showPrompt = target != null && target.CanInteract;

            if (showPrompt)
                promptText.text = "[E] " +
                    target.InteractionPrompt.ToUpperInvariant();

            promptRoot.SetActive(showPrompt);
        }

        private void OnValidate()
        {
            if (promptText == null)
                promptText = GetComponentInChildren<TextMeshProUGUI>(true);
        }
    }
}

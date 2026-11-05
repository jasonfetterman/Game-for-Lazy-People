namespace Game.Interaction
{
    public interface IInteractable
    {
        string InteractionName { get; }
        string InteractionPrompt { get; }
        bool CanInteract { get; }

        void Interact();
    }
}

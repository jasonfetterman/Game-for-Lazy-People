using Game.Player;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.UI
{
    [DisallowMultipleComponent]
    public sealed class HungerUI : MonoBehaviour
    {
        [SerializeField] private HungerSystem hunger;
        [SerializeField] private Slider hungerSlider;
        [SerializeField] private TextMeshProUGUI hungerText;

        private void Awake()
        {
            if (hunger == null)
                hunger = FindFirstObjectByType<HungerSystem>();
        }

        private void OnEnable()
        {
            if (hunger != null)
                hunger.HungerChanged += HandleHungerChanged;

            Refresh();
        }

        private void OnDisable()
        {
            if (hunger != null)
                hunger.HungerChanged -= HandleHungerChanged;
        }

        private void HandleHungerChanged(float current, float maximum)
        {
            Refresh();
        }

        private void Refresh()
        {
            if (hunger == null)
                return;

            float current = hunger.CurrentHunger;
            float maximum = hunger.MaximumHunger;

            if (hungerSlider != null)
                hungerSlider.value = current / maximum;

            if (hungerText != null)
                hungerText.text = $"HUNGER  {current:F0}%";
        }
    }
}

using System;
using UnityEngine;

namespace Game.Player
{
    [DisallowMultipleComponent]
    public sealed class HungerSystem : MonoBehaviour
    {
        [Header("Hunger Settings")]
        [SerializeField, Range(0f, 100f)]
        private float startingHunger = 100f;

        [SerializeField, Min(0f)]
        private float hungerDrainPerSecond = 0.05f;

        private float currentHunger;

        public float CurrentHunger => currentHunger;
        public float MaximumHunger => 100f;
        public float HungerPercent => currentHunger / 100f;
        public bool IsStarving => currentHunger <= 0f;

        public event Action<float, float> HungerChanged;

        private void Awake()
        {
            currentHunger = Mathf.Clamp(startingHunger, 0f, 100f);
        }

        private void Update()
        {
            if (currentHunger <= 0f || hungerDrainPerSecond <= 0f)
                return;

            SetHunger(currentHunger - hungerDrainPerSecond * Time.deltaTime);
        }

        public void RestoreHunger(float amount)
        {
            if (amount <= 0f)
                return;

            SetHunger(currentHunger + amount);
        }

        private void SetHunger(float value)
        {
            float previousHunger = currentHunger;
            currentHunger = Mathf.Clamp(value, 0f, 100f);

            if (!Mathf.Approximately(previousHunger, currentHunger))
                HungerChanged?.Invoke(currentHunger, 100f);
        }

        private void OnValidate()
        {
            startingHunger = Mathf.Clamp(startingHunger, 0f, 100f);
            hungerDrainPerSecond = Mathf.Max(0f, hungerDrainPerSecond);
        }
    }
}

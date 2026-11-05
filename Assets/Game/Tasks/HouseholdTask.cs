using System;
using Game.Economy;
using UnityEngine;

namespace Game.Tasks
{
    [DisallowMultipleComponent]
    public sealed class HouseholdTask : MonoBehaviour
    {
        [Header("Task")]
        [SerializeField] private string taskName = "Clean Up";
        [SerializeField, TextArea] private string description =
            "Complete this household chore.";
        [SerializeField, Min(1)] private int reward = 25;

        [Header("State")]
        [SerializeField] private bool completed;

        private PlayerWallet wallet;

        public string TaskName => taskName;
        public string Description => description;
        public int Reward => reward;
        public bool IsCompleted => completed;

        public event Action<HouseholdTask> TaskCompleted;

        public void Initialize(PlayerWallet playerWallet)
        {
            wallet = playerWallet;
        }

        public bool Complete()
        {
            if (completed || wallet == null)
                return false;

            if (!wallet.Earn(reward))
                return false;

            completed = true;
            TaskCompleted?.Invoke(this);

            Debug.Log($"Task completed: {taskName}. Earned ${reward}.");
            return true;
        }
    }
}

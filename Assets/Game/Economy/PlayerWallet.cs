using System;
using UnityEngine;

namespace Game.Economy
{
    [DisallowMultipleComponent]
    public sealed class PlayerWallet : MonoBehaviour
    {
        [Header("Wallet")]
        [SerializeField, Min(0)] private int startingBalance = 100;

        private int balance;

        public int Balance => balance;

        public event Action<int> BalanceChanged;

        private void Awake()
        {
            balance = startingBalance;
        }

        public bool Earn(int amount)
        {
            if (amount <= 0)
                return false;

            if (balance > int.MaxValue - amount)
                return false;

            balance += amount;
            BalanceChanged?.Invoke(balance);
            return true;
        }

        public bool Spend(int amount)
        {
            if (amount <= 0 || balance < amount)
                return false;

            balance -= amount;
            BalanceChanged?.Invoke(balance);
            return true;
        }

        public bool CanAfford(int amount)
        {
            return amount > 0 && balance >= amount;
        }

        private void OnValidate()
        {
            startingBalance = Mathf.Max(0, startingBalance);
        }
    }
}

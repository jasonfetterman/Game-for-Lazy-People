using Game.Economy;
using TMPro;
using UnityEngine;

namespace Game.UI
{
    [DisallowMultipleComponent]
    public sealed class MoneyHUD : MonoBehaviour
    {
        [SerializeField] private PlayerWallet wallet;
        [SerializeField] private TMP_Text balanceText;

        private void OnEnable()
        {
            if (wallet != null)
                wallet.BalanceChanged += UpdateBalance;
        }

        private void Start()
        {
            Refresh();
        }

        private void OnDisable()
        {
            if (wallet != null)
                wallet.BalanceChanged -= UpdateBalance;
        }

        public void Refresh()
        {
            if (wallet == null || balanceText == null)
                return;

            UpdateBalance(wallet.Balance);
        }

        private void UpdateBalance(int balance)
        {
            if (balanceText != null)
                balanceText.text = "$" + balance.ToString("N0");
        }
    }
}

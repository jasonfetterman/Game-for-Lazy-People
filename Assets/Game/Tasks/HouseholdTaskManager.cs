using Game.Economy;
using UnityEngine;

namespace Game.Tasks
{
    [DisallowMultipleComponent]
    public sealed class HouseholdTaskManager : MonoBehaviour
    {
        [SerializeField] private PlayerWallet playerWallet;

        private void Awake()
        {
            if (playerWallet == null)
            {
                GameObject player = GameObject.Find("PLAYER_INSTANCE");

                if (player != null)
                    playerWallet = player.GetComponent<PlayerWallet>();
            }

            if (playerWallet == null)
            {
                Debug.LogError(
                    "HouseholdTaskManager could not find the player's wallet.");
                return;
            }

            HouseholdTask[] tasks =
                FindObjectsByType<HouseholdTask>(
                    FindObjectsSortMode.None);

            foreach (HouseholdTask task in tasks)
                task.Initialize(playerWallet);

            Debug.Log(
                $"Household task manager initialized. Connected {tasks.Length} tasks.");
        }
    }
}

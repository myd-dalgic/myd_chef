using UnityEngine;
using EquatorStudios.VRCooking.Data;

namespace EquatorStudios.VRCooking.Core
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private OrderManager orderManager;
        [SerializeField] private OrderDefinitionSO[] orderPool;
        [SerializeField] private int completedOrders;

        private void Start()
        {
            SpawnNextOrder();
        }

        public void OnOrderCompleted()
        {
            completedOrders++;
            SpawnNextOrder();
        }

        public void SpawnNextOrder()
        {
            if (orderPool == null || orderPool.Length == 0)
                return;

            int index = Random.Range(0, orderPool.Length);
            orderManager.SetActiveOrder(orderPool[index]);
        }
    }
}

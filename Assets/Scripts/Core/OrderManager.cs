using System.Collections.Generic;
using UnityEngine;
using EquatorStudios.VRCooking.Data;
using EquatorStudios.VRCooking.Food;
using EquatorStudios.VRCooking.Stations;

namespace EquatorStudios.VRCooking.Core
{
    public class OrderManager : MonoBehaviour
    {
        [SerializeField] private ServingTray servingTray;
        [SerializeField] private OrderDefinitionSO activeOrder;

        public void SetActiveOrder(OrderDefinitionSO order)
        {
            activeOrder = order;
        }

        public bool ValidateCurrentTray()
        {
            if (activeOrder == null)
                return false;

            List<FoodItem> trayItems = servingTray.GetTrayFoodItems();

            foreach (var line in activeOrder.Items)
            {
                int count = 0;
                foreach (var item in trayItems)
                {
                    if (item == null || item.Definition == null)
                        continue;

                    if (item.Definition.FoodType == line.FoodType && item.IsValidForServing())
                        count++;
                }

                if (count < line.Quantity)
                    return false;
            }

            return true;
        }
    }
}

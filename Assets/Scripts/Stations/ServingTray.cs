using System.Collections.Generic;
using UnityEngine;
using EquatorStudios.VRCooking.Food;

namespace EquatorStudios.VRCooking.Stations
{
    public class ServingTray : MonoBehaviour
    {
        [SerializeField] private List<FoodItem> items = new List<FoodItem>();

        public List<FoodItem> GetTrayFoodItems()
        {
            return new List<FoodItem>(items);
        }

        public void RegisterFood(FoodItem item)
        {
            if (item != null && !items.Contains(item))
                items.Add(item);
        }

        public void UnregisterFood(FoodItem item)
        {
            items.Remove(item);
        }

        public void ClearAll()
        {
            items.Clear();
        }
    }
}

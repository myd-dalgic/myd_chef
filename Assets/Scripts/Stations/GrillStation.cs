using System.Collections.Generic;
using UnityEngine;
using EquatorStudios.VRCooking.Food;

namespace EquatorStudios.VRCooking.Stations
{
    public class GrillStation : StationBase
    {
        [SerializeField] private float cookSpeed = 12f;
        [SerializeField] private List<FoodItem> itemsOnGrill = new List<FoodItem>();

        private void Update()
        {
            if (!CanOperate())
                return;

            for (int i = 0; i < itemsOnGrill.Count; i++)
            {
                if (itemsOnGrill[i] != null)
                    itemsOnGrill[i].AddCookProgress(cookSpeed * Time.deltaTime);
            }
        }

        public void AddFood(FoodItem food)
        {
            if (!itemsOnGrill.Contains(food))
                itemsOnGrill.Add(food);
        }

        public void RemoveFood(FoodItem food)
        {
            itemsOnGrill.Remove(food);
        }
    }
}

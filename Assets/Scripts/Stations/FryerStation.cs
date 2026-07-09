using System.Collections.Generic;
using UnityEngine;
using EquatorStudios.VRCooking.Food;

namespace EquatorStudios.VRCooking.Stations
{
    public class FryerStation : StationBase
    {
        [SerializeField] private float cookSpeed = 15f;
        [SerializeField] private bool basketLowered;
        [SerializeField] private List<FoodItem> basketContents = new List<FoodItem>();

        private void Update()
        {
            if (!CanOperate() || !basketLowered)
                return;

            for (int i = 0; i < basketContents.Count; i++)
            {
                if (basketContents[i] != null)
                    basketContents[i].AddCookProgress(cookSpeed * Time.deltaTime);
            }
        }

        public void SetBasketLowered(bool lowered)
        {
            basketLowered = lowered;
        }

        public void AddToBasket(FoodItem food)
        {
            if (!basketContents.Contains(food))
                basketContents.Add(food);
        }
    }
}

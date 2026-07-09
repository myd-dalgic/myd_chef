using UnityEngine;
using EquatorStudios.VRCooking.Food;
using EquatorStudios.VRCooking.Data;

namespace EquatorStudios.VRCooking.Stations
{
    public class DrinkDispenserStation : StationBase
    {
        [SerializeField] private float fillSpeed = 35f;
        [SerializeField] private FoodItem currentCup;
        [SerializeField] private bool leverPulled;

        private void Update()
        {
            if (!CanOperate() || !leverPulled || currentCup == null)
                return;

            if (currentCup.Definition != null && currentCup.Definition.FoodType == FoodType.SodaCupEmpty)
            {
                currentCup.AddCookProgress(fillSpeed * Time.deltaTime);
            }
        }

        public void SetCup(FoodItem cup)
        {
            currentCup = cup;
        }

        public void SetLeverState(bool pulled)
        {
            leverPulled = pulled;
        }
    }
}

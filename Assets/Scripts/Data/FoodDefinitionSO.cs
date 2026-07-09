using UnityEngine;

namespace EquatorStudios.VRCooking.Data
{
    public enum FoodType
    {
        Fries,
        BurgerPatty,
        BurgerAssembled,
        HotdogSausage,
        HotdogAssembled,
        SodaCupEmpty,
        SodaCupFilled
    }

    [CreateAssetMenu(menuName = "Equator Studios/Food Definition")]
    public class FoodDefinitionSO : ScriptableObject
    {
        public FoodType FoodType;
        public string DisplayName;
        public bool CanCatchFire = true;
        public float CookedThreshold = 50f;
        public float BurnThreshold = 85f;
        public float FireThreshold = 100f;
    }
}

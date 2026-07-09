using System.Collections.Generic;
using UnityEngine;

namespace EquatorStudios.VRCooking.Data
{
    [System.Serializable]
    public class OrderLine
    {
        public FoodType FoodType;
        public int Quantity = 1;
    }

    [CreateAssetMenu(menuName = "Equator Studios/Order Definition")]
    public class OrderDefinitionSO : ScriptableObject
    {
        public string OrderName;
        public List<OrderLine> Items = new List<OrderLine>();
        public Sprite OrderIcon;
    }
}

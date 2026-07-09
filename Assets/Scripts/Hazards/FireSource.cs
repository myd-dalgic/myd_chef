using UnityEngine;

namespace EquatorStudios.VRCooking.Hazards
{
    public class FireSource : MonoBehaviour
    {
        [SerializeField] private float extinguishRequiredTime = 2f;
        private float currentExtinguishTime;
        public bool IsActive { get; private set; }

        public void Ignite()
        {
            IsActive = true;
            currentExtinguishTime = 0f;
        }

        public void ApplyExtinguish(float amount)
        {
            if (!IsActive)
                return;

            currentExtinguishTime += amount;
            if (currentExtinguishTime >= extinguishRequiredTime)
                Extinguish();
        }

        public void Extinguish()
        {
            IsActive = false;
            currentExtinguishTime = 0f;
        }
    }
}

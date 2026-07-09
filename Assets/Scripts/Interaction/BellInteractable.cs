using UnityEngine;
using UnityEngine.Events;

namespace EquatorStudios.VRCooking.Interaction
{
    public class BellInteractable : MonoBehaviour
    {
        public UnityEvent OnBellRang;

        public void RingBell()
        {
            OnBellRang?.Invoke();
        }
    }
}

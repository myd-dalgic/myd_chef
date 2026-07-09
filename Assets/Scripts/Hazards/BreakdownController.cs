using UnityEngine;
using EquatorStudios.VRCooking.Stations;

namespace EquatorStudios.VRCooking.Hazards
{
    public class BreakdownController : MonoBehaviour
    {
        [SerializeField] private StationBase station;
        [SerializeField] private int requiredHits = 3;
        [SerializeField] private float minImpactForce = 2.5f;

        private int currentHits;

        public void TriggerBreakdown()
        {
            currentHits = 0;
            station.BreakDown();
        }

        public void RegisterRepairHit(float impactForce)
        {
            if (station == null || station.MachineState != MachineState.Broken)
                return;

            if (impactForce < minImpactForce)
                return;

            currentHits++;

            if (currentHits >= requiredHits)
            {
                currentHits = 0;
                station.CompleteRepair();
            }
        }
    }
}

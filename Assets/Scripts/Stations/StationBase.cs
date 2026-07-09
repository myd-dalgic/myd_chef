using UnityEngine;

namespace EquatorStudios.VRCooking.Stations
{
    public enum MachineState
    {
        Working,
        Broken,
        Repairing
    }

    public abstract class StationBase : MonoBehaviour
    {
        [field: SerializeField] public MachineState MachineState { get; protected set; } = MachineState.Working;

        public virtual bool CanOperate()
        {
            return MachineState == MachineState.Working;
        }

        public virtual void BreakDown()
        {
            MachineState = MachineState.Broken;
        }

        public virtual void CompleteRepair()
        {
            MachineState = MachineState.Working;
        }
    }
}

using UnityEngine;
using EquatorStudios.VRCooking.Data;

namespace EquatorStudios.VRCooking.Food
{
    public enum FoodState
    {
        Raw,
        Cooking,
        Cooked,
        Burnt,
        OnFire,
        Ruined,
        Served
    }

    public class FoodItem : MonoBehaviour
    {
        [field: SerializeField] public FoodDefinitionSO Definition { get; private set; }
        [field: SerializeField] public FoodState CurrentState { get; private set; } = FoodState.Raw;
        [SerializeField] private float cookProgress;
        [SerializeField] private bool ruined;
        [SerializeField] private bool onFire;

        public void SetDefinition(FoodDefinitionSO definition)
        {
            Definition = definition;
            cookProgress = 0f;
            ruined = false;
            onFire = false;
            CurrentState = FoodState.Raw;
        }

        public void AddCookProgress(float amount)
        {
            if (Definition == null || ruined || onFire || CurrentState == FoodState.Served)
                return;

            cookProgress += amount;
            UpdateStateFromProgress();
        }

        public void MarkRuined()
        {
            ruined = true;
            CurrentState = FoodState.Ruined;
        }

        public void Ignite()
        {
            if (Definition == null || !Definition.CanCatchFire)
                return;

            onFire = true;
            CurrentState = FoodState.OnFire;
        }

        public void Extinguish()
        {
            onFire = false;
            CurrentState = FoodState.Burnt;
        }

        public bool IsValidForServing()
        {
            return !ruined && !onFire && CurrentState != FoodState.Raw && CurrentState != FoodState.Burnt;
        }

        private void UpdateStateFromProgress()
        {
            if (Definition == null)
                return;

            if (cookProgress >= Definition.FireThreshold)
            {
                Ignite();
            }
            else if (cookProgress >= Definition.BurnThreshold)
            {
                CurrentState = FoodState.Burnt;
            }
            else if (cookProgress >= Definition.CookedThreshold)
            {
                CurrentState = FoodState.Cooked;
            }
            else
            {
                CurrentState = FoodState.Cooking;
            }
        }
    }
}

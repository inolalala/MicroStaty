using Microstaty.Scripts.Interface;
using Unity.Collections;
using UnityEngine;
using System;

namespace Microstaty.Scripts.MonoBehavior
{
    [DisallowMultipleComponent]
    public abstract class StateMonoBehaviorBase<TStateEnumType> : MonoBehaviour, IState
    {
        [SerializeField, ReadOnly]
        private TStateEnumType stateType;

        public TStateEnumType StateType
        {
            get => stateType;
            set => stateType = value;
        }

        public IState GetMyStateType()
        {
            return this;
        }

        public virtual void OnEnter(Action onEnterHandler, params int[] p)
        {
            onEnterHandler?.Invoke();
        }

        public virtual void OnExit(Action onExitHandler, params int[] p)
        {
            onExitHandler?.Invoke();
        }
    }
}


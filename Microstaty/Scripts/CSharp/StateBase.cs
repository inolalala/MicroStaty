using Microstaty.Scripts.Interface;
using System;

namespace Microstaty.Scripts.CSharp
{
    [Serializable]
    public abstract class StateBase<TStateEnumType> : IState
    {
        private TStateEnumType _stateType;

        public TStateEnumType StateType
        {
            get => _stateType;
            set => _stateType = value;
        }

        public IState GetMyStateType()
        {
            return this;
        }
        
        public virtual void OnEnter(Action onEnterHandler, params int[] p)
        {
            
        }

        public virtual void OnExit(Action onExitHandler, params int[] p)
        {
            
        }
    }
}

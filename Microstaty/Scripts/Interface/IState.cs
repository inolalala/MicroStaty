using System;

namespace Microstaty.Scripts.Interface
{
    public interface IState
    {
        IState GetMyStateType();
        void OnEnter(Action onEnterHandler,params int[] args);
        void OnExit(Action onExitHandler, params int[] args);
    }
}
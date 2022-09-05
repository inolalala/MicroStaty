using System;
using System.Collections.Generic;
using System.Linq;
using Microstaty.Scripts.Interface;
using UnityEngine;

namespace Microstaty.Scripts.CSharp
{
    public abstract class StateContextBase<TStateEnumType>
    {
        private IState _currentState;
        public IState CurrentState => _currentState;
        //
        // private readonly Dictionary<TStateEnumType, IState> _stateObjectDictionary;

        private readonly Stack<IState> _stateStack = new Stack<IState>();
        public IState PreviousState => _stateStack.Peek();
        

        // private readonly Dictionary<TStateEnumType, Action> _onEnterHandlerDictionary;
        // private readonly Dictionary<TStateEnumType, Action> _onExitHandlerDictionary;

        private StateContextConfig<TStateEnumType> _config;
        public StateContextConfig<TStateEnumType> Config
        {
            get => _config;
            set => _config = value;
        }

        public StateContextBase(TStateEnumType initialSample, StateContextConfig<TStateEnumType> config)
        {
            _config = config;

            _currentState = config.StateObjectDictionary[initialSample];
            _stateStack.Push(_currentState);
            _currentState.OnEnter(config.OnEnterHandlerDictionary[initialSample],0);
        }
    
        public void ChangeState(TStateEnumType nextStateType, params int[] p)
        {
            //現在のStateオブジェクトのEnumキーを取得
            TStateEnumType currentStateType = _config.StateObjectDictionary.FirstOrDefault(s => s.Value == _currentState).Key;
            
            //現在のStateのExit処理
            Action onExitHandler = _config.OnExitHandlerDictionary[currentStateType];
            _currentState.OnExit(onExitHandler, p);
            _stateStack.Pop();
            
            //現在のStateのEnter処理
            _currentState = _config.StateObjectDictionary[nextStateType];
            _stateStack.Push(_currentState);
            Action onEnterHandler = _config.OnEnterHandlerDictionary[nextStateType];
            _currentState.OnEnter(onEnterHandler, p);
        }
    }
}

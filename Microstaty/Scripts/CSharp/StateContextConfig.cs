using System;

using System.Collections.Generic;
using Microstaty.Scripts.Interface;

namespace Microstaty.Scripts.CSharp
{
    public class StateContextConfig<TStateEnumType>
    {
        public Dictionary<TStateEnumType, IState> StateObjectDictionary { get; }
        public Dictionary<TStateEnumType, Action> OnEnterHandlerDictionary { get; }
        public Dictionary<TStateEnumType, Action> OnExitHandlerDictionary { get; }

        public StateContextConfig(
            Dictionary<TStateEnumType, IState> stateObjectDic,
            Dictionary<TStateEnumType,Action>　onEnterHandlerDic, 
            Dictionary<TStateEnumType, Action> onExitHandlerDic)
        {
            StateObjectDictionary = stateObjectDic;
            OnEnterHandlerDictionary = onEnterHandlerDic;
            OnExitHandlerDictionary = onExitHandlerDic;
        }
    }
}

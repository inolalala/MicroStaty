using System;
using System.Linq;
using System.Collections.Generic;
using Microstaty.Scripts.CSharp;
using Microstaty.Scripts.Interface;
using UnityEngine;

namespace Microstaty.Scripts.MonoBehavior
{
    public abstract class StateContextMonoBehaviorBase<TStateEnumType> : MonoBehaviour
    {
        protected StateContextBase<TStateEnumType> context = null;
        public abstract void Initialize();
    
        public virtual void ChangeState(TStateEnumType nextStateType, params int[] p)
        {
            context?.ChangeState(nextStateType, p);
        }
    }
}
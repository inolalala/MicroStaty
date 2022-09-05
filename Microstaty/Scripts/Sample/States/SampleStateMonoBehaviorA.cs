using System;
using Microstaty.Scripts.MonoBehavior;
using UnityEngine;

namespace Microstaty.Scripts.Sample
{
    public class SampleStateMonoBehaviorA : StateMonoBehaviorBase<SampleType>
    {
        // override methods if you wanted to.
        
        // public override void OnEnter(Action onEnterHandler, params int[] p)
        // {
        //     base.OnEnter(onEnterHandler, p);
        //     Debug.Log(this.StateType.ToString());
        // }
        //
        // public override void OnExit(Action onExitHandler, params int[] p)
        // {
        //     base.OnExit(onExitHandler, p);
        //     Debug.Log(this.StateType.ToString());
        // }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using Microstaty.Scripts.CSharp;
using Microstaty.Scripts.Interface;
using Microstaty.Scripts.MonoBehavior;
using UnityEngine;

namespace Microstaty.Scripts.Sample
{
    public class SampleStateContextMonoBehavior : StateContextMonoBehaviorBase<SampleType>
    {
        [SerializeField] private SampleContextConfigurationMonoBehavior configurationMonoBehavior;

        public override void Initialize()
        {
            StateContextConfig<SampleType> config = configurationMonoBehavior.Set();
            base.context = new SampleContext(SampleType.A, config);
        }
    }
}


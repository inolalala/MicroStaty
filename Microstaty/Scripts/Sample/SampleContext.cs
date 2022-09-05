

using System;
using System.Collections.Generic;
using Microstaty.Scripts.CSharp;
using Microstaty.Scripts.Interface;

namespace Microstaty.Scripts.Sample
{
    public class SampleContext : StateContextBase<SampleType>
    {
        public SampleContext(SampleType initialSample, StateContextConfig<SampleType> config) : base(initialSample, config)
        {
        }
    }
}

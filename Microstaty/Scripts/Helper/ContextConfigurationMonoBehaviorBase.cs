using Microstaty.Scripts.CSharp;
using Microstaty.Scripts.Interface;
using Microstaty.Scripts.MonoBehavior;
using UnityEngine;

namespace Microstaty.Scripts.Helper
{
    public abstract class ContextConfigurationMonoBehaviorBase<TStateEnumType> : MonoBehaviour, IContextConfig<TStateEnumType>
    {
        [SerializeField] protected StateMonoBehaviorBase<TStateEnumType>[] stateObjects;
        public abstract StateContextConfig<TStateEnumType> Set();
    }
}

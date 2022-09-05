using Microstaty.Scripts.CSharp;
using Microstaty.Scripts.Sample;

namespace Microstaty.Scripts.Interface
{
    public interface IContextConfig<TStateEnumType>
    {
        StateContextConfig<TStateEnumType> Set();
    }
}

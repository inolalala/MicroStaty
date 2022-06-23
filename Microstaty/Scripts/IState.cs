namespace Microstaty
{
    public interface IState
    {
        void OnEnter(params int[] args);
        void OnExit(params int[] args);
    }
}
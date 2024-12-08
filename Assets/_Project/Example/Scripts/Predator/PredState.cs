public abstract class PredState : State
{
    public PredEnt predEnt;
    public PredState(PredEnt _predEnt, StateMachine _sM) : base((Entity)_predEnt, _sM)
    {
        predEnt = _predEnt;
    }
}

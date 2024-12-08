public abstract class PreyState : State
{
    public PreyEnt preyEnt;
    public PreyState(PreyEnt _preyChara, StateMachine _sM) : base((Entity)_preyChara, _sM)
    {
        preyEnt = _preyChara;
    }
}

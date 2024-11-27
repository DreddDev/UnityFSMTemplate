public abstract class PreyState : State
{
    public PreyCharacter preyChara;
    public PreyState(PreyCharacter _preyChara, StateMachine _sM) : base((Character)_preyChara, _sM)
    {
        preyChara = _preyChara;
    }
}

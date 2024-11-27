public abstract class PredState : State
{
    public PredCharacter predChara;
    public PredState(PredCharacter _predChara, StateMachine _sM) : base((Character)_predChara, _sM)
    {
        predChara = _predChara;
    }
}

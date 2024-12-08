using UnityEditor.Presets;

public abstract class PlayerState : State
{
    public PlayerEnt plEnt;
    public PlayerState(PlayerEnt _plEnt, StateMachine _sM) : base((Entity)_plEnt, _sM)
    {
        plEnt = _plEnt;
    }
    public virtual void InputUpdate()
    {

    }
}

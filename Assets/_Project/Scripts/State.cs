public abstract class State
{
    public Character chara;
    public StateMachine sM;

    public State(Character _chara, StateMachine _sM)
    {
        chara = _chara;
        sM = _sM;
    }
    public virtual void Enter()
    {

    }
    public virtual void HandleInput()
    {

    }
    public virtual void LogicUpdate()
    {

    }
    public virtual void PhysicsUpdate()
    {

    }
    public virtual void Exit()
    {

    }
}

public abstract class State
{
    public Entity ent;
    public StateMachine sM;

    public State(Entity _ent, StateMachine _sM)
    {
        ent = _ent;
        sM = _sM;
    }
    public virtual void Enter()
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

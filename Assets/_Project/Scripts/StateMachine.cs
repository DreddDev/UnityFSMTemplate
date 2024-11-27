public class StateMachine
{
    public State currentState;

    public void Initalize(State _startingState)
    {
        currentState = _startingState;
        _startingState.Enter();
    }
    public void ChangeState(State _newState)
    {
        currentState.Exit();
        currentState = _newState;
        _newState.Enter();
    }
}

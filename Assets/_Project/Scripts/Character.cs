using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public StateMachine sM;
    protected virtual void Awake()
    {

    }
    protected virtual void Start()
    {

    }
    protected virtual void Update()
    {
        sM.currentState.HandleInput();
        sM.currentState.LogicUpdate();
    }
    protected virtual void FixedUpdate()
    {
        sM.currentState.PhysicsUpdate();
    }
}

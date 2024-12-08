using UnityEngine;

public abstract class Entity : MonoBehaviour
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
        sM.currentState.LogicUpdate();
    }
    protected virtual void FixedUpdate()
    {
        sM.currentState.PhysicsUpdate();
    }
}

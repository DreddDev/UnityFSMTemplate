using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerEnt : Entity
{
    protected override void Awake()
    {
        base.Awake();
    }
    protected override void Start()
    {
        base.Start();
    }
    protected override void Update()
    {
        PlayerState pState = (PlayerState)sM.currentState;
        pState.InputUpdate();
        base.Update();
    }
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }
}

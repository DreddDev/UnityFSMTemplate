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
        pState.InputUpdate(); //I feel like there's a cleaner way to call this instead of casting it in an variable first, but if it works, it works! :P
        base.Update();
    }
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }
}

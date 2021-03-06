﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RunState : CharacterState {
    protected virtual float SpeedModifier
    {
        get { return 400f; }
    }
    public override void Enter(Character character)
    {
        base.Enter(character);
        this.character.CharAnimator.SetFloat("Speed", 40);
    }


    public override void FixedUpdate()
    {
        base.FixedUpdate();
        this.character.Move(this.character.HorizontalMove * SpeedModifier * Time.deltaTime);
    }

}

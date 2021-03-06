﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UpdateableBase
{
    public void Initialize()
    {
        NonMonoUpdateManager.Instance.RegisterUpdateable(this);
    }

    public abstract void Update();
}

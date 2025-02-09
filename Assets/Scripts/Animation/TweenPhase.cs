using System;
using UnityEngine;

[System.Serializable]
[Flags]
public enum TweenPhase
{
    NONE    = 0,
    AWAKE   = 1 << 0,
    ENABLE  = 1 << 1,
    START   = 1 << 2,
    DISABLE = 1 << 3,
    DESTROY = 1 << 4
}

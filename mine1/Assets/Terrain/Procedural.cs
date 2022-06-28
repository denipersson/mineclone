using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Procedural
{
    public static int GLOBAL_HEIGHT_MULTIPLIER = 10;
    public static int BlockHeight(int x, int z)
    {
        int y = (int)(Mathf.PerlinNoise(x * 0.05f, z * 0.05f) * GLOBAL_HEIGHT_MULTIPLIER);
        return y;
    }
}

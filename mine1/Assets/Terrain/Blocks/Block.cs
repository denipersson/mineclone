using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : Cube
{
    BlockInfo blockInfo;

    protected override void Awake()
    {
        base.Awake();
    }

    public void SetBlock(BlockInfo blockInfo)
    {
        this.blockInfo = blockInfo;
        meshRenderer.material.color = blockInfo.color;
    }
    
}

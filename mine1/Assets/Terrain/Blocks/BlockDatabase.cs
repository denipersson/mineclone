using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDatabase 
{
    private Dictionary<int, BlockInfo> database = new Dictionary<int, BlockInfo>();

    public BlockDatabase()
    {
        Initialize();
    }

    private void Initialize()
    {
        database.Add(0, new BlockInfo("Grass", 2, false, true, true, true, BlockInfo.toolableTool.shovel, Color.green));
    }
    public BlockInfo GetBlockInfo(int id)
    {
        return database[id];
    }
}
public struct BlockInfo
{
    public string name;
    public int secondsToMine;
    public bool flammable;
    public bool plantable;
    public bool animalsSpawnableOn;
    public bool toolable;
    public toolableTool tool;
    public Color color;

    public enum toolableTool
    {
        axe, shovel, pickaxe
    }

    public BlockInfo(string name, int secondsToMine, bool flammable, bool plantable, bool animalsSpawnableOn, bool toolable, toolableTool tool, Color color)
    {
        this.name = name;
        this.secondsToMine = secondsToMine;
        this.flammable = flammable;
        this.plantable = plantable;
        this.animalsSpawnableOn = animalsSpawnableOn;
        this.toolable = toolable;
        this.tool = tool;
        this.color = color;
    }
    
}

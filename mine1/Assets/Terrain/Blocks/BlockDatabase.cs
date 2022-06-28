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
        database.Add(1, new BlockInfo("Dirt", 2, false, true, false, true, BlockInfo.toolableTool.shovel, new Color(58.8f/255f, 29.4f/255f, 0)));
        database.Add(2, new BlockInfo("Stone", 10, false, false, false, true, BlockInfo.toolableTool.pickaxe, Color.grey));
        database.Add(3, new BlockInfo("Sand", 2, false, true, false, true, BlockInfo.toolableTool.shovel, Color.yellow));
    }
    public BlockInfo GetBlockInfo(int id)
    {
        return database[id];
    }
    public int CalculateBlockID(int y)
    {
        if (y > 0)
            return 0;
        else if (y > -3f)
            return 1;
        else
            return 2;
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

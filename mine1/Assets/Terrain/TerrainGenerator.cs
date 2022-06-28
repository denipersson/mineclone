using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    [SerializeField]
    private Cube block;
    private int width = 64;
    [SerializeField]
    private List<Chunk> chunks = new List<Chunk>();
    private int blockCount = 0;

    void Start()
    {
        GenerateChunk(Vector3.zero);
    }

    void Update()
    {
        
    }

    private void GenerateChunk(Vector3 pos)
    {
        Chunk newChunk = new Chunk(pos);
        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < width; z++)
            {
                GameObject newBlock = GameObject.Instantiate(block.gameObject, this.transform);
                Vector3 coord = new Vector3(x + pos.x, Procedural.BlockHeight(x, z) + pos.y, z + pos.z);
                newChunk.AddBlock(newBlock, coord);
                blockCount++;
            }
        }
        Debug.Log("Block count: " + blockCount);
        chunks.Add(newChunk);
    }
}

public struct Chunk
{
    Vector3 pos;
    Dictionary<Vector3, GameObject> blocks;

    public Chunk(Vector3 pos)
    {
        this.pos = pos;
        blocks = new Dictionary<Vector3, GameObject>();
    }
    public Vector3 getPos()
    {
        return pos;
    }
    public void AddBlock(GameObject block, Vector3 coord)
    {
        blocks.Add(coord, block);
        block.transform.position = coord;
    }
    
}

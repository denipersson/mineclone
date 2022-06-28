using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Grid
{
    public bool displayVertices = false;
    [SerializeField]
    private Material mat;
    private MeshCollider coll;

    protected override void Awake()
    {
        base.Awake();
        if(mat)
            meshRenderer.material = mat;

        coll = GetComponent<MeshCollider>();
        coll.sharedMesh = mesh;
        
    }
    protected override void SetTriangles()
    {
        triangles = new int[6 * 6];

        //front face
        triangles[0] = 0;
        triangles[1] = 1;
        triangles[2] = 3;
        triangles[3] = 3;
        triangles[4] = 1;
        triangles[5] = 2;

        //right face
        triangles[6] = 3;
        triangles[7] = 2;
        triangles[8] = 6;
        triangles[9] = 6;
        triangles[10] = 7;
        triangles[11] = 3;

        //left face
        triangles[12] = 0;
        triangles[13] = 4;
        triangles[14] = 1;
        triangles[15] = 4;
        triangles[16] = 5;
        triangles[17] = 1;

        //top face
        triangles[18] = 1;
        triangles[19] = 5;
        triangles[20] = 2;
        triangles[21] = 2;
        triangles[22] = 5;
        triangles[23] = 6;

        //back face
        triangles[24] = 7;
        triangles[25] = 6;
        triangles[26] = 5;
        triangles[27] = 5;
        triangles[28] = 4;
        triangles[29] = 7;

        //bottom face
        triangles[30] = 0;
        triangles[31] = 3;
        triangles[32] = 4;
        triangles[33] = 3;
        triangles[34] = 7;
        triangles[35] = 4;

        mesh.triangles = triangles;

    }
    protected override void SetVertices()
    {
        vertices = new Vector3[8];
        
        vertices[0] = new Vector3(0, 0, 0);
        vertices[1] = new Vector3(0, 1, 0);
        vertices[2] = new Vector3(1, 1, 0);
        vertices[3] = new Vector3(1, 0, 0);
        vertices[4] = new Vector3(0, 0, 1);
        vertices[5] = new Vector3(0, 1, 1);
        vertices[6] = new Vector3(1, 1, 1);
        vertices[7] = new Vector3(1, 0, 1);

        mesh.vertices = vertices;

    }
    private void OnDrawGizmos()
    {
        if (!displayVertices)
            return;

        Gizmos.color = Color.red;

        foreach (Vector3 v in vertices)
            Gizmos.DrawWireCube(v, Vector3.one * 0.05f);       
    }
}


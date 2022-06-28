using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    protected Vector3[] vertices;
    protected int[] triangles;
    protected Vector2[] uvs;
    protected MeshFilter meshFilter;
    protected MeshRenderer meshRenderer;
    protected Mesh mesh;

    protected virtual void Awake()
    {
        meshFilter = gameObject.AddComponent<MeshFilter>();
        meshRenderer = gameObject.AddComponent<MeshRenderer>();
        mesh = new Mesh();

        SetVertices();
        SetTriangles();
        SetUVs();
        mesh.Optimize();
        mesh.RecalculateNormals();
        meshFilter.mesh = mesh;

    }

    protected virtual void SetVertices()
    {
        vertices = new Vector3[4];
        vertices[0] = new Vector3(0, 0, 0);
        vertices[1] = new Vector3(0, 0, 1);
        vertices[2] = new Vector3(1, 0, 1);
        vertices[3] = new Vector3(1, 0, 0);

        mesh.vertices = vertices;
    }

    protected virtual void SetTriangles()
    {
        triangles = new int[6];

        triangles[0] = 0;
        triangles[1] = 1;
        triangles[2] = 3;

        triangles[3] = 3;
        triangles[4] = 1;
        triangles[5] = 2;

        mesh.triangles = triangles;
    }
    protected virtual void SetUVs()
    {
        uvs = new Vector2[vertices.Length];

        for(int v = 0; v < vertices.Length; v++)
        {
            uvs[v] = new Vector2(vertices[v].x, vertices[v].y);
        }
        mesh.uv = uvs;
    }


}

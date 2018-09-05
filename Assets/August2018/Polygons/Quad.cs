using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quad : MonoBehaviour
{
    public Vector3[] points;
    void Update()
    {
        var filter = GetComponent<MeshFilter>();
        var mesh = new Mesh();
        filter.mesh = mesh;

        // Vertices
        // locations of vertices
        var verts = new Vector3[4];

        verts[0] = points[0];
        verts[1] = points[1];
        verts[2] = points[2];
        verts[3] = points[3];

        mesh.vertices = verts;

        // Indices
        // determines which vertices make up an individual triangle
        var indices = new int[6];

        indices[0] = 3;
        indices[1] = 1;
        indices[2] = 0;

        indices[3] = 3;
        indices[4] = 2;
        indices[5] = 1;

        mesh.triangles = indices;

        var UVs = new Vector2[4];

        //UVs[0] = new Vector2(0, 0);
        //UVs[1] = new Vector2(1, 0);
        //UVs[2] = new Vector2(1, 1);
        //UVs[3] = new Vector2(0, 1);

        UVs[0] = points[0];
        UVs[1] = points[1];
        UVs[2] = points[2];
        UVs[3] = points[3];

        mesh.uv = UVs;

        Material m_Material = GetComponent<Renderer>().material;
    }
}
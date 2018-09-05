using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pentagon : MonoBehaviour
{
    void Start()
    {
        var filter = GetComponent<MeshFilter>();
        var mesh = new Mesh();
        filter.mesh = mesh;

        // Vertices
        // locations of vertices
        var verts = new Vector3[5];

        verts[0] = new Vector3(0, 0, 0);
        verts[1] = new Vector3(1, 0, 0);
        verts[2] = new Vector3(1.5f, 1, 0);
        verts[3] = new Vector3(0.5f, 1.8f, 0);
        verts[4] = new Vector3(-0.5f, 1, 0);

        mesh.vertices = verts;

        // Indices
        // determines which vertices make up an individual triangle
        var indices = new int[9];

        indices[0] = 3;
        indices[1] = 1;
        indices[2] = 0;

        indices[3] = 3;
        indices[4] = 2;
        indices[5] = 1;

        indices[6] = 0;
        indices[7] = 4;
        indices[8] = 3;

        mesh.triangles = indices;
    }
}
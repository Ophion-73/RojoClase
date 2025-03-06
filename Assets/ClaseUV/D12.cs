using System.Collections.Generic;
using UnityEngine;

public class D12 : MonoBehaviour
{
    // Prefab to spawn
    public GameObject prefab;

    // Array of vertices to spawn objects at
    private Vector3[] vertices = new Vector3[]
    {
        //0
        new Vector3(-0.72f, 5.40f, 4.71f),
        //1
        new Vector3(-0.41f, 8.43f, 2.84f),
        //2
        new Vector3(-2.93f, 8.43f, 0.31f),
        //3
        new Vector3(-4.80f, 5.40f, 0.62f),
        //4
        new Vector3(-3.43f, 3.53f, 3.33f),
        //5
        new Vector3(-1.31f, 8.41f, -2.86f),
        //6
        new Vector3(-2.17f, 5.37f, -4.52f),
        //7
        new Vector3(-4.33f, 3.51f, -2.37f),
        //8
        new Vector3(-2.67f, 0.47f, -1.50f),
        //9
        new Vector3(-2.11f, 0.49f, 2.02f),
        //10
        new Vector3(2.77f, 8.41f, 1.22f),
        //11
        new Vector3(2.21f, 8.39f, -2.30f),
        //12
        new Vector3(1.41f, 0.47f, 2.58f),
        //13
        new Vector3(2.27f, 3.51f, 4.24f),
        //14
        new Vector3(4.43f, 5.37f, 2.09f),
        //15
        new Vector3(0.82f, 3.48f, -4.99f),
        //16
        new Vector3(0.51f, 0.45f, -3.12f),
        //17
        new Vector3(3.03f, 0.45f, -0.59f),
        //18
        new Vector3(4.90f, 3.48f, -0.90f),
        //19
        new Vector3(3.53f, 5.35f, -3.61f)
    };
    int[] triangles = {
        
        };

    void Start()
    {
        // Create the Mesh
        Mesh mesh = new Mesh();
        mesh.vertices = vertices;
        mesh.triangles = triangles;


        // Calculate normals for lighting
        mesh.RecalculateNormals();

        // Apply the mesh to the MeshFilter and set the material
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        meshFilter.mesh = mesh;

        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        
    }

}

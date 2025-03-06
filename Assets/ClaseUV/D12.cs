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
        //face0
        //t0
         0, 1, 2,
         //t1
         0, 2, 3,
         //t2
         0, 3, 4,
        //face1
        //t0
        12,13,0,
        //t1
        12,0,4,
        //t2
        12,4,9,
        //face2
        //t1
        14,10,1,
        //t2
        14,1,0,
        //t3
        14,0,13,
        //face3
        //t1
        9,8,16,
        //t2
        9,16,17,
        //t3
        9,17,12,
        //face4
        //t1
        9,4,3,
        //t2
        9,3,7,
        //t3
        9,7,8,
        //face5
        //t1
        17,18,14,
        //t2
        17,14,13,
        //t3
        17,13,12,
        //face6
        //t1
        2,1,10,
        //t2 
        2,10,11,
        //t3  
        2,11,5,
        //face7
        //t1
        7,3,2,
        //t2
        7,2,5,
        //t3
        7,5,6,
        //face8
        //t1
        18,19,11,
        //t2 
        18,11,10,
        //t3  
        18,10,14,
        //face9
        //t1
        15,6,5,
        //t2 
        15,5,11,
        //t3  
        15,11,19,
        //face10
        //t1
        8,7,6,
        //t2
        8,6,15,
        //t3  
        8,15,16,
        //face11
        //t1
        16,15,19,
        //t2 
        16,19,18,
        //t3  s
        16,18,17
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

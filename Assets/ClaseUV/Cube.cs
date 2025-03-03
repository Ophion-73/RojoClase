
using UnityEngine;
using System.Collections.Generic;
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class Cube : MonoBehaviour
{
    public Material material;
    void Start()
    {
        CreateCube();
    }

    private void CreateCube()
    {
        float size = 1f;
        Vector3[] vertices = {
            //0
            new Vector3(0, 0, 0),
            //1
            new Vector3(6, 0, 0),
            //2
            new Vector3(3, 0, 5.2f),
            //3
            new Vector3(3, 5.74f, 1.7325f),
            //4
            new Vector3(12, 0, 0),
            //5
            new Vector3(9, 5.740001f, 1.7325f),
            //6
            new Vector3(9, 0, 5.2f),
            //7
            new Vector3(6f, 0, 10.4f),
            //8
            new Vector3(6f, 5.740001f, 7.07f),
            //9
            new Vector3(6f, 11.48f, 3.61f),



        };



        int[] triangles = {
            //1
            0,3,1,
            1,3,2,
            2,3,0,
            1,2,0,
            //2
            1,5,4,
            4,5,6,
            6,5,1,
            6,1,4,
            //3
            6,8,7,
            7,8,2,
            2,8,6,
            2,6,7,
            //4
            8,3,5,
            3,9,5,
            5,9,8,
            8,9,3,
            //centro
            //abajo
            2,1,6,
            //frente
            1,3,5,
            //derecha
            6,5,8,
            //izquierda
            2,8,3




        };



        Mesh mesh = GetComponent<MeshFilter>().mesh;
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        
        meshRenderer.material = material;
        mesh.Optimize();
        mesh.RecalculateNormals();
    }

}
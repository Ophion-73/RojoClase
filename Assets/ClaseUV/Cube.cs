
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
            new Vector3(0, 0, 0),
            //5
            new Vector3(0, 0, 0),
            //6
            new Vector3(12, 0, 0),
            //7
            new Vector3(9, 0, 5.2f),
            //8
            new Vector3(9, 5.740001f, 1.7325f),
            //9
            new Vector3(6, 0, 0),
            //10
            new Vector3(12, 0, 0),
            //11
            new Vector3(12, 0, 0),
            //12
            new Vector3(6f, 0, 10.4f),
            //13
            new Vector3(9, 0, 5.2f),
            //14
            new Vector3(6f, 5.740001f, 7.07f),
            //15
            new Vector3(6f, 0, 10.4f),
            //16
            new Vector3(3, 0, 5.2f),
            //17
            new Vector3(6f, 0, 10.4f),
            //18
            new Vector3(6f, 11.48f, 3.61f),
            //19
            new Vector3(9, 5.740001f, 1.7325f),
            //20
            new Vector3(6f, 11.48f, 3.61f),
            //21
            new Vector3(3, 5.74f, 1.7325f),
            //22
            new Vector3(6f, 5.740001f, 7.07f),
            //23
            new Vector3(6f, 11.48f, 3.61f),
            //24
            new Vector3(6, 0, 0),
            //25
            new Vector3(3, 0, 5.2f),
            //26
            new Vector3(9, 5.740001f, 1.7325f),
            //27
            new Vector3(3, 5.74f, 1.7325f),
            //28
            new Vector3(6f, 5.740001f, 7.07f),
            //29
            new Vector3(3, 0, 5.2f),
            //30
            new Vector3(9, 5.740001f, 1.7325f),
            //31
            new Vector3(9, 0, 5.2f),
            //32
            new Vector3(6, 0, 0),
            //33
            new Vector3(3, 0, 5.2f),
        };



        int[] triangles = {
            //C
            1,0,3,
            3,4,2,
            2,5,1,
            1,3,2,
            //D
            7,8,9,
            7,6,8,
            9,8,11,
            10,7,9,
            //A
            13,16,14,
            15,16,13,
            13,14,12,
            16,17,14,
            //punto
            21,19,22,
            18,19,21,
            19,20,22,
            21,22,23,
            //AAAAAAPORQUEEEEYAESTARDEYAQUIERODORMIR
            33,32,31,
            32,30,31,
            31,30,28,
            31,28,29,
            29,28,27,
            26,27,28,
            26,24,27,
            24,25,27,


        };

        Vector2[] uvs = {
            //piramide1
            //0
            new Vector2(0.0448f, 0.7027f),
            //1
            new Vector2(0.22f, 0.5807f),
            //2
            new Vector2(0.3876f, 0.7023f),
            //3
            new Vector2(0.22f, 0.8248f),
            //4
            new Vector2( 0.3876f,0.9496f),
            //5
            new Vector2(0.3876f, 0.4526f),
            
            //piramide2
            //6
            new Vector2(0.4302f,0.9857f),
            //7
            new Vector2(0.4302f,0.7379f),
            //8
            new Vector2(0.5978f, 0.8590f),
            //9
            new Vector2(0.5978f, 0.6130f),
            //10
            new Vector2(0.4302f,0.4877f),
            //11
            new Vector2(0.7679F,0.7379f),

            //piramide 3
            //12
            new Vector2(0.9563f,0.8405f),
            //13
            new Vector2(0.7909f,0.6949f),
            //14
            new Vector2(0.9563f,0.5895f),
            //15
            new Vector2(0.6186f,0.5895f),
            //16
            new Vector2(0.7909f,0.4508f),
            //17
            new Vector2(0.9563f,0.3398f),
            
            //piramide 3
            //18
            new Vector2(0.0419f, 0.6459f),
            //19
            new Vector2(0.0419f, 0.3957f),
            //20
            new Vector2(0.0419f, 0.1456f),
            //21
            new Vector2(0.2128f,0.5196f),
            //22
            new Vector2(0.2128f,0.2691f),
            //23
            new Vector3( 0.3825f,0.3957f),
            
            //aBOMINACIONiNTERNA
            //24
            new Vector2(0.2612f,0.2788f),
            //25
            new Vector2(0.2612f,0.0254f),
            //26
            new Vector2(0.4339f,0.4027f),
            //27
            new Vector2(0.4339f,0.1544f),
            //28
            new Vector2(0.6047f,0.2788f),
            //29
            new Vector2(0.6047f,0.0254f),
            //30
            new Vector2(0.7774f,0.4027f),
            //31
            new Vector2(0.7774f,0.1544f),
            //32
            new Vector2(0.9479f,0.2788f),
            //33
            new Vector2(0.9479f,0.0254f),




        };


        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uvs;
        mesh.Optimize();
        mesh.RecalculateNormals();
    }

}
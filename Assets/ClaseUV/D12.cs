using System.Collections.Generic;
using UnityEngine;

public class D12 : MonoBehaviour
{
    // Prefab to spawn
    public GameObject prefab;

    // Array of vertices to spawn objects at
    private Vector3[] vertices = new Vector3[]
    {
        //new Vector3(,,),
        //0
        new Vector3(-0.57735f, -0.57735f, 0.57735f),
        //1
        new Vector3(0, -0.356822f, 0.934172f),
        //2
        new Vector3(-0.356822f, -0.934172f, 0),
        //3
        new Vector3(0.356822f, -0.934172f, 0),
        //4
         new Vector3(0.57735f, -0.57735f, 0.57735f),
        //5
        new Vector3(0, -0.356822f, 0.934172f),
        //6
        new Vector3(0,0.356822f,0.934172f),
        //7
        new Vector3(0.57735f,0.57735f,0.57735f),
        //8
        new Vector3(0.934172f,0,0.356822f),
        //9
        new Vector3(0.57735f,-0.57735f,-0.57735f),
        //10
        new Vector3(-0.356822f, -0.934172f, 0),
        //11
        new Vector3(-0.57735f,-0.57735f,-0.57735f),
        //12
        new Vector3(0,-0.356822f,-0.934172f),
        //13
        new Vector3(0.934172f,0,-0.356822f),
        //14
        new Vector3(0.57735f,0.57735f,0.57735f),
        //15
        new Vector3(0.356822f,0.934172f,0),
        //16
        new Vector3(0.57735f,0.57735f,-0.57735f),
        //17
        new Vector3(0,-0.356822f,-0.934172f),
        //18
        new Vector3(0.57735f,0.57735f,-0.57735f),
        //19
        new Vector3(0,0.356822f,-0.934172f),
        //20
        new Vector3(-0.57735f,-0.57735f,-0.57735f),
        //21
        new Vector3(-0.934172f,0,-0.356822f),
        //22
        new Vector3(-0.57735f,0.57735f,-0.57735f),
        //23
        new Vector3(0,0.356822f,-0.934172f),
        //24
        new Vector3(-0.57735f,-0.57735f,-0.57735f),
        //25
        new Vector3(-0.356822f, -0.934172f, 0),
        //26
        new Vector3(-0.57735f, -0.57735f, 0.57735f),
        //27
        new Vector3(-0.934172f,0,0.356822f),
        //28
        new Vector3(0.57735f,0.57735f,-0.57735f),
        //29
        new Vector3(-0.356822f,0.934172f,0),
        //30
        new Vector3(0.356822f,0.934172f,0),
        //31
        new Vector3(-0.57735f,0.57735f,0.57735f),
        //32
        new Vector3(0,0.356822f,0.934172f),
        //33
        new Vector3(0, -0.356822f, 0.934172f),
        //34
        new Vector3(-0.57735f, -0.57735f, 0.57735f),
        //35
        new Vector3(0,0.356822f,0.934172f),
        //36
        new Vector3(0.57735f,0.57735f,0.57735f),
        //37
        new Vector3(0.356822f,0.934172f,0),



    };
    int[] triangles = {
        //4
        2,3,0,
        3,4,0,
        0,4,1,
        //10
        5,7,6,
        4,7,5,
        4,8,7,
        //5
        9,4,3,
        9,8,4,
        9,13,8,
        //1
        3,10,11,
        3,11,12,
        3,12,9,
        //9
        13,14,8,
        13,16,14,
        16,15,14,
        //6
        17,13,9,
        17,19,13,
        19,18,13,
        //2
        21,17,20,
        21,19,17,
        21,22,19,
        //12
        31,21,27,
        31,22,21,
        31,29,22,
        //3
        26,24,25,
        26,21,24,
        26,27,21,
        //11
        34,31,27,
        33,31,34,
        33,32,31,
        //7
        35,36,31,
        36,29,31,
        36,37,29,
        //8
        29,23,22,
        29,28,23,
        29,30,28,
        };

    Vector2[] uvs = {
            //new Vector2(),
            //0
            new Vector2(0.371756f,0.964878f),
            //1
            new Vector2(0.534951f,0.964878f),
            //2
            new Vector2(0.314714f,0.848079f),
            //3
            new Vector2(0.45625f,0.77777f),
            //4
            new Vector2(0.598187f,0.849451f),
            //5
            new Vector2(0.65932f,0.961963f),
            //6
            new Vector2(0.822515f,0.960291f),
            //7
            new Vector2(0.85225f,0.85225f),
            //8
            new Vector2(0.736952f,0.775385f),
            //9
            new Vector2(0.512624f,0.660259f),
            //10
            new Vector2(0.286193f,0.777114f),
            //11
            new Vector2(0.227106f,0.661745f),
            //12
            new Vector2(0.36178f, 0.58625f),
            //13
            new Vector2(0.67991f,0.661444f),
            //14
            new Vector2(0.918556f,0.763713f),
            //15
            new Vector2(0.97361f,0.661386f),
            //16
            new Vector2(0.826857f,0.593092f),
            //17
            new Vector2(0.457627f,0.543461f),
            //18
            new Vector2(0.730874f,0.545789f),
            //19
            new Vector2(0.598438f,0.473681f),
            //20
            new Vector2(0.319056f,0.472309f),
            //21
            new Vector2(0.368396f,0.35876f),
            //22
            new Vector2(0.539351f,0.360262f),
            //23
            new Vector2(0.688149f,0.425177f),
            //24
            new Vector2(0.221027f,0.428335f),
            //25
            new Vector2(0.086546f,0.357184f),
            //26
            new Vector2(0.13751f,0.243429f),
            //27
            new Vector2(0.315023f,0.240329f),
            //28
            new Vector2(0.824869f,0.358254f),
            //29
            new Vector2(0.598496f,0.243128f),
            //30
            new Vector2(0.767827f,0.245741f),
            //31
            new Vector2(0.461969f,0.171977f),
            //32
            new Vector2(0.394701f,0.056607f),
            //33
            new Vector2(0.22946f,0.056851f),
            //34
            new Vector2(0.176451f,0.170605f),
            //35
            new Vector2(0.508842f,0.056794f),
            //36
            new Vector2(0.680219f,0.055121f),
            //37
            new Vector2(0.735215f,0.174776f),

        };

    void Start()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uvs;
        mesh.Optimize();
        mesh.RecalculateNormals();

    }

}

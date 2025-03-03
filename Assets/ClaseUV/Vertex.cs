using UnityEngine;

public class Vertex : MonoBehaviour
{
    
    private void Start()
    {
        var meshFilter = GetComponent<MeshFilter>();

        Mesh mesh = meshFilter.mesh;

        Vector3[] meshVerts = mesh.vertices;

        Debug.Log(mesh.vertexCount);

        //Debug.Log("points = " + meshVerts.Length);

        var matrix = transform.localToWorldMatrix;

        for (int i = 0; i < meshVerts.Length; i++)
        {
            Vector3 worldv = matrix.MultiplyPoint(meshVerts[i]);
            Debug.Log("vertex = " + worldv);
        }
    }
       
}

using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class ThreeFacePyramid : MonoBehaviour
{
    public Material material; // Material to apply to the pyramid

    void Start()
    {
        CreatePyramid();
    }

    private void CreatePyramid()
    {
        // Define the size of the pyramid base
        float size = 1f;
        float height = 1.5f;  // Height of the pyramid

        // Vertices: 4 points (1 for the apex, 3 for the base)
        Vector3[] vertices = {
            new Vector3(0, height, 0), // Apex (top of the pyramid)
            new Vector3(-size / 2, 0, -size / 2), // Base vertex 1
            new Vector3(size / 2, 0, -size / 2), // Base vertex 2
            new Vector3(0, 0, size / 2)  // Base vertex 3
        };

        // Triangles: 3 faces, each consisting of 3 vertices
        int[] triangles = {
            0, 1, 2, // Face 1
            0, 2, 3, // Face 2
            0, 3, 1  // Face 3
        };

        // UVs: simple mapping for each vertex
        Vector2[] uv = {
            new Vector2(0.5f, 1),   // Apex
            new Vector2(0, 0),      // Base vertex 1
            new Vector2(1, 0),      // Base vertex 2
            new Vector2(0.5f, 0)    // Base vertex 3
        };

        // Create the Mesh
        Mesh mesh = new Mesh();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uv;

        // Calculate normals for lighting
        mesh.RecalculateNormals();

        // Apply the mesh to the MeshFilter and set the material
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        meshFilter.mesh = mesh;

        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = material;  // Set the material of the pyramid
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets;

public class polyGenerator : MonoBehaviour {

	// Use this for initialization
	void Start () {
        createPoly();
	}


	
	// Update is called once per frame
	void Update () {
		
	}

    private void createPoly()
    {
        // Create Vector2 vertices
        Vector2[] vertices2D = new Vector2[] {
            new Vector2(0,0),
            new Vector2(0,5),
            new Vector2(5,5),
            new Vector2(5,10),
            new Vector2(0,10),
            new Vector2(0,15),
            new Vector2(15,15),
            new Vector2(15,10),
            new Vector2(10,10),
            new Vector2(10,5),
            new Vector2(15,5),
            new Vector2(15,0),
        };

        // Use the triangulator to get indices for creating triangles
        Triangulator tr = new Triangulator(vertices2D);
        int[] indices = tr.Triangulate();

        // Create the Vector3 vertices
        Vector3[] vertices = new Vector3[vertices2D.Length];
        PolygonCollider2D p = gameObject.AddComponent(typeof(PolygonCollider2D)) as PolygonCollider2D;
       
        p.pathCount = 1;
        p.SetPath(0, vertices2D);
        //p.SetPath(1, null);
        for (int i = 0; i < vertices.Length; i++)
        {
            vertices[i] = new Vector3(vertices2D[i].x, vertices2D[i].y, 0);
           
            
        }

        // Create the mesh
        Mesh msh = new Mesh();
        msh.vertices = vertices;
        msh.triangles = indices;
        msh.RecalculateNormals();
        msh.RecalculateBounds();

        // Set up game object with mesh;
        gameObject.AddComponent(typeof(MeshRenderer));
        MeshFilter filter = gameObject.AddComponent(typeof(MeshFilter)) as MeshFilter;
        filter.mesh = msh;
    }
}

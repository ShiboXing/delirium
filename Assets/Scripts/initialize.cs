using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initialize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var mesh = GetComponent<SkinnedMeshRenderer>().sharedMesh;
        var collider = gameObject.AddComponent<MeshCollider>();
        //var rb = gameObject.AddComponent<Rigidbody>();

        //rb.useGravity = false;
        //rb.mass = 100f;
        collider.sharedMesh = mesh;
        collider.convex = true;
        Debug.Log(collider);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereVectors : MonoBehaviour
{
    public Vector3 firstVector = new Vector3(0.0f, 0.0f, 0.0f);
    public Vector3 secondVector = new Vector3(0.0f, 0.0f, 0.0f);
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Magnitude of Vector 1: " + Math.Sqrt(Math.Pow(firstVector.x, 2) + Math.Pow(firstVector.y, 2) + Math.Pow(firstVector.z, 2)));
        Debug.Log("Magnitude of Vector 2: " + Math.Sqrt(Math.Pow(secondVector.x, 2) + Math.Pow(secondVector.y, 2) + Math.Pow(secondVector.z, 2)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

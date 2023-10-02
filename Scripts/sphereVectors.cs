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
        double magnitude1 = Math.Sqrt(Math.Pow(firstVector.x, 2) + Math.Pow(firstVector.y, 2) + Math.Pow(firstVector.z, 2));
        double magnitude2 = Math.Sqrt(Math.Pow(secondVector.x, 2) + Math.Pow(secondVector.y, 2) + Math.Pow(secondVector.z, 2));
        double dotProduct = (firstVector.x * secondVector.x) + (firstVector.y * secondVector.y) + (firstVector.z * secondVector.z);
        Debug.Log("Magnitude of Vector 1: " + magnitude1);
        Debug.Log("Magnitude of Vector 2: " + magnitude2);
        Debug.Log("Angle between Vectors: " + Math.Acos(dotProduct / (magnitude1 * magnitude2)) * Mathf.Rad2Deg);
        Debug.Log("Distance between Vectors: " + Math.Pow(Math.Pow(secondVector.x - firstVector.x, 2) + Math.Pow(secondVector.y - firstVector.y, 2) + 
                                                          Math.Pow(secondVector.z - firstVector.z, 2), 0.5f));
                                                          
        if(firstVector.y > secondVector.y) {
            Debug.Log("Vector 1 is higher");
        } else if (firstVector.y == secondVector.y) {
            Debug.Log("They are at the same height");
        } else {
            Debug.Log("Vector 2 is higher");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereDistances : MonoBehaviour
{
    public GameObject cube;
    public GameObject cylinder;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Distance between sphere and cube: " + Math.Pow(Math.Pow(transform.position.x - cube.transform.position.x, 2) +
                                                                  Math.Pow(transform.position.y - cube.transform.position.y, 2) + 
                                                                  Math.Pow(transform.position.z - cube.transform.position.z, 2), 0.5f));
        Debug.Log("Distance between sphere and cilinder: " + Math.Pow(Math.Pow(transform.position.x - cylinder.transform.position.x, 2) +
                                                                      Math.Pow(transform.position.y - cylinder.transform.position.y, 2) + 
                                                                      Math.Pow(transform.position.z - cylinder.transform.position.z, 2), 0.5f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

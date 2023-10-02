using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class sphereGroups : MonoBehaviour
{
    public GameObject cube;
    public GameObject group01;
    public GameObject group02;
    public Material changeMat;

    private List<Double> distances = new List<Double>();
    private Material oldMat;
    
    // Start is called before the first frame update
    void Start()
    {
        foreach(Transform child in group02.transform) {
            double temp = Math.Pow(Math.Pow(cube.transform.position.x - child.transform.position.x, 2) +
                          Math.Pow(cube.transform.position.y - child.transform.position.y, 2) + 
                          Math.Pow(cube.transform.position.z - child.transform.position.z, 2), 0.5f);
            distances.Add(temp);
        }
        double minVal = distances.Min();
        Transform raiseObject = group02.transform.GetChild(distances.IndexOf(minVal)); 
        raiseObject.position = new Vector3(raiseObject.transform.position.x, raiseObject.transform.position.y + 3, raiseObject.transform.position.z);

        oldMat = group02.transform.GetChild(distances.IndexOf(distances.Max())).GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            double maxVal = distances.Max();
            Transform raiseObject = group02.transform.GetChild(distances.IndexOf(maxVal)); 
            if (raiseObject.GetComponent<MeshRenderer>().material.color == changeMat.color) {
                raiseObject.GetComponent<MeshRenderer>().material = oldMat;
            } else {
                raiseObject.GetComponent<MeshRenderer>().material = changeMat;
            }
        }
    }
}

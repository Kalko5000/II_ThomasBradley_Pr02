using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour
{
    public GameObject cube;
    public GameObject cylinder;
    public Material changeMat;

    private Material oldCubeMat;
    private Material oldCylinderMat;
    
    // Start is called before the first frame update
    void Start()
    {
        oldCubeMat = cube.GetComponent<MeshRenderer>().material;
        oldCylinderMat = cylinder.GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)) {
            if(cylinder.GetComponent<MeshRenderer>().material.color == changeMat.color) {
                cylinder.GetComponent<MeshRenderer>().material = oldCylinderMat;
            } else {
                cylinder.GetComponent<MeshRenderer>().material = changeMat;
            }
        } else if (Input.GetKeyDown(KeyCode.UpArrow)) {
            if(cube.GetComponent<MeshRenderer>().material.color == changeMat.color) {
                cube.GetComponent<MeshRenderer>().material = oldCubeMat;
            } else {
                cube.GetComponent<MeshRenderer>().material = changeMat;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alignObjects : MonoBehaviour
{
    public GameObject sphere;
    public GameObject cube;
    public GameObject cylinder;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cylinder.transform.position = new Vector3(sphere.transform.position.x + 5, sphere.transform.position.y, sphere.transform.position.z);
        cube.transform.position = new Vector3(sphere.transform.position.x - 5, sphere.transform.position.y, sphere.transform.position.z);
    }
}

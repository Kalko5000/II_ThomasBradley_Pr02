using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomArray : MonoBehaviour
{
    public int[] numbers = new int[5];
    
    // Start is called before the first frame update
    void Start()
    {
        string initialArrayString = "";
        for(int i = 0; i < numbers.Length; i++) {
            numbers[i] = Random.Range(0,25); 
            initialArrayString += numbers[i] + " ";
        }
        Debug.Log("Initial Array: " + initialArrayString);
    }

    // Update is called once per frame
    void Update()
    {
        int randomPosition = Random.Range(0,4);
        numbers[randomPosition] =  Random.Range(0,25); 
        string consoleText = "";
        for(int i = 0; i < numbers.Length; i++) {
            if(numbers[i] > 15) {
                consoleText += numbers[i] + " ";
            } 
        }
        Debug.Log("Values Greater Than Fifteen: " + consoleText);
    }
}
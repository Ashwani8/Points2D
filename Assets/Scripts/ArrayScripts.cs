using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayScripts : MonoBehaviour
{
    // first we declare Array by using  []square brack with the type of the object we wants to create
    public int[] rollNumber; // declare array of int type, one can declare size either in script of in unity
    string[] studentName = new string[5] ; // declare and create array of size 5, index from 0 to 4
    
    // Start is called before the first frame update
    void Start()
    {
       print(rollNumber[2]);// will print the value stored at index number 2, will print 5 for odd numbers stored in array
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

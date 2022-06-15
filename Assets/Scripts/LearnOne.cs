using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Even handeling in Unity
public class LearnOne : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // print(" ") will print the string inside the console 
        print("Start function was called");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // OnEnable funtion is called first, even before the start
    private void OnEnable()
    {
        print("OnEnable function is called");
    }
    private void OnDisable()
    {
        print("script is disable by registering OnDisable even");
    }
}

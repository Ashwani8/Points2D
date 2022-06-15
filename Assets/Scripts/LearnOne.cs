using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// we must attach the script to a game object to see its effect.
// Even handeling in Unity
public class LearnOne : MonoBehaviour
{
    // it is very typical to assign or define variable here in the begening of the class

    // There are 5 main type of variable we can use
   private int intVariable = 7;
    float variableFloat = 2.5f; // note the f after the decimal number
    char characterVar = 'a'; // note the use of single quotation
    string varString = "This is a String";
    public int score = 5; // here score is public variable and will be available in inspecter for changne
                          // and is accessible outside the class
    // Start is called before the first frame update
    void Start()
    {
        // print(" ") will print the string inside the console 
        print("Start function was called");

        // Variable type
        print("This is integer " + intVariable);
        print("This is float number " + variableFloat);
        print("This is float Char, characteristic vairable  " + characterVar);
        print("This is string " + varString);
        print("This is a public variable " + score);
        // there has to be another way to use variable inside the quation marks.
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Revew basic C sharp 
public class LearnTwo : MonoBehaviour
{
    bool playing = false; // defining variable booliean typ
    bool running = false;
    // Start is called before the first frame update
    void Start()
    {
        // conditional statement; if(playing == true) is same as belwo
        if (playing)
        {
            print(" keep playing");
        } else if(!running){
            print("please stop playing video game and start running");
        }
        else
        {
            print("Game Over");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

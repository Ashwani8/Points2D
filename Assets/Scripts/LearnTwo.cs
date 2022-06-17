using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Revew basic C sharp 
public class LearnTwo : MonoBehaviour
{
    bool playing = false; // defining variable booliean typ
   public bool running ;
    public bool killPlayer ;
    // Start is called before the first frame update
    void Start()
    {
        // conditional statement; if(playing == true) is same as belwo
        if (playing)
        {
            print(" keep playing");
        } else if (killPlayer)
        {
            Destroy (gameObject); // will destroy the GameObject to which the script is attached
        }
        else if(!running){
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

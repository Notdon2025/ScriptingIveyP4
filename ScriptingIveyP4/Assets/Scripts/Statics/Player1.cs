using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    //Static variable are shared across all instances //of a cllass.
    public static int playerCount = 0;
    // Start is called before the first frame update
    void Start()
    {
     //Increment the static variable to know how many //objects of this class have been created.
     playerCount++;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

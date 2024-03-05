using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static int enemyCount = 0;
    // Start is called before the first frame update
    public Enemy()
    {
        //Increment the static variable to know how many // objects of this cllass have been created.
        enemyCount++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

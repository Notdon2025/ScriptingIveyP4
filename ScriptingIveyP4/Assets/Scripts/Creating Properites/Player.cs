using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    internal static int playerCount;

    // Start is called before the first frame update
    private int experience;

    public int Experience
    {
        get
        {
            //Some other code
            return experience;

        }
        set
        {
            //Some other code
            experience = value;
        }
    }

    // Update is called once per frame
    public int Level
    {
        get
        {
            return experience / 1000;

        }
        set
        {
            experience = value * 1000;
        }
    }
    public int Health { get; set; }

     void Start()
    {

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClass : MonoBehaviour
{
    //The first Add method has signature of 
    //"Add(int, int)". This signature must be unique.
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //The second Add method has a signature of 
    //"Add(String, string)". Again, this must be unique.
    public string Add(string str1, string str2)
    {
        return str1 + str2;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    internal void GenericMethod<T>(T v)
    {
        throw new NotImplementedException();
    }
}

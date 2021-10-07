using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       for (int i = 0; i < 5; i++)
       {
           Console.WriteLine(i);
       } 
    }
}

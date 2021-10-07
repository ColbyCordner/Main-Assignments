using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhileLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        do
        {
            Console.WriteLine(i);
            i++;
        }
        while (i < 5);
    }
}

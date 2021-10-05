using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultStatements : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
   {
      int day = 4;
      switch (day) 
      {
        case 6:
          Console.WriteLine("Today is Saturday.");
          break;
        case 7:
          Console.WriteLine("Today is Sunday.");
          break;
        default:
          Console.WriteLine("Looking forward to the Weekend.");
          break;
      }    
    }
}

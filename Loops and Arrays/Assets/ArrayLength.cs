using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayLength : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      Console.WriteLine(cars.Length);
    }
}

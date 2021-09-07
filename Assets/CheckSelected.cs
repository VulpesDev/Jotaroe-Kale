using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSelected : MonoBehaviour
{
    public static GameObject[] Int;
    public static int counter = 0;
    public static bool Check()
    {
        counter = 0;
        Int = GameObject.FindGameObjectsWithTag("IntItem");
        for (int i = 0; i < Int.Length; i++)
        {
            if(Int[i].GetComponent<Item>().Selected)
            {
                counter++;
            }
        }
        if(counter == 1)
        {//ready to go
            return true;
            
        }
        else
        {//select only one item
            return false;
            
        }
    }
}

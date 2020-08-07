using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Terminal.WriteLine("************Welcome Hacker************\nWhat would you like to hack?");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the local police station");
        Terminal.WriteLine("Enter your choice");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

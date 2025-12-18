using System;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Console.WriteLine("rotate");
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        Console.WriteLine("rotate end");
    }
}

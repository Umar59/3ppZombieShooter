using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Cube1 : MonoBehaviour
{
    
    public GameObject hero;
    public float movementSpeed = 2f;

    
    void FixedUpdate()
    {
        transform.position += UnityEngine.Vector3.Normalize(hero.transform.position-transform.position) * movementSpeed * Time.deltaTime;

        if (UnityEngine.Vector3.Distance(hero.transform.position, transform.position) < 10f)
        {
            Debug.Log("too close");

        }

    }
}

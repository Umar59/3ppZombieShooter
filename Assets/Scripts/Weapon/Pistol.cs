using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour, Gun
{
    
    public Transform transformForRay;
   


    public void Shoot()
    {
        
        
        Ray ray = new Ray(transformForRay.position, transformForRay.forward);
        
             RaycastHit hit;
             
             if (Physics.Raycast(ray, out hit))
             {
                 if (hit.collider.gameObject.name == "enemy")
                 {
                     
                   //  hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.red;
                 }
             }
            
            Debug.Log("Pistol shooting");
        
    }
}

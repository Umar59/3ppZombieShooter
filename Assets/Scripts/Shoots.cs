using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoots : MonoBehaviour
{
    [HideInInspector]
    public bool state;

    public WeaponSwitch currentWeapon;

    
    

    // Update is called once per frame
    void Update()
    {
        Shoot(state);
    }

    public void Shoot(bool check_state)
    {
        if (check_state)
        {
            Ray ray = new Ray(transform.position, transform.forward);

            RaycastHit hit;
            
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name == "enemy")
                {
                    
                    hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.red;
                }
            }
        }
    }
    
    
    
    
}

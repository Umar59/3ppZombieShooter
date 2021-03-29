using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK : MonoBehaviour, Gun
{
    public int damage = 10;
    public Transform transformForRay;

 
    public void Shoot()
    {
        Ray ray = new Ray(transformForRay.position, transformForRay.forward);
        RaycastHit hit;


        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.name == "enemy")
            {
                EnemyDamage target = hit.transform.GetComponent<EnemyDamage>();
                target.TakeDamage(damage);  
            }
        }

    }

}

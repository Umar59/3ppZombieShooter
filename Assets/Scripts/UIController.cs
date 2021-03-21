
using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIController : MonoBehaviour
{
    [SerializeField]
    public WeaponSwitch weaponSwitch;

    public AnimationHero animationHero;
    
    
    
    
    public void RefreshCurrentWeapon()
    {
        if ((int)weaponSwitch.currentWeapon == 2)
        {
            weaponSwitch.currentWeapon = 0;
        }
        else
        {
             weaponSwitch.currentWeapon++;
        }
       
        
        
        
        Debug.Log(weaponSwitch.currentWeapon);
    }

   
    
    
    
    

   
}

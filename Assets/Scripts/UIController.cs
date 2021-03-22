
using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIController : MonoBehaviour, IPointerDownHandler
{
    public WeaponSwitch _weaponSwitch;
    
    
    
    
    
    public void OnPointerDown(PointerEventData eventData)
    {
        _weaponSwitch.RefreshCurrentWeapon();
    }

   

   
    
    
    
    

   
}

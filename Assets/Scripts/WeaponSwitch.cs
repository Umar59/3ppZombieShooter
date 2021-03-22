using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public WeaponType currentWeapon = 0;
    public PlayerController _playerController;
    public AK ak;
    public Pistol pistol;
    public Rifle rifle;
        

    private List<Gun> _guns = new List<Gun>();
    


    private void Start()
    {
        
        _guns.Add(pistol);
        _guns.Add(ak);
        _guns.Add(rifle);
        _guns.Add(null);
        _playerController.gun = pistol;
    }

    private void Update()
    {
        SelectWeapon();
    }


    void SelectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == (int) currentWeapon)
            {
                weapon.gameObject.SetActive(true);
            }
            else
                weapon.gameObject.SetActive(false);

            i++;
        }
    }
    
    public void RefreshCurrentWeapon()
    {
        
        if ((int)currentWeapon == 3)
        {
            currentWeapon = 0;
            _playerController.gun = _guns[(int)currentWeapon];
        }
        else
        {
            currentWeapon++;
            _playerController.gun = _guns[(int)currentWeapon];
        }
       
        
        
        
       
    }
    
    
}
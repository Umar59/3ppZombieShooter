using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public WeaponType currentWeapon = 0;

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
    
    

    // public enum GunType
    // {
    //     Pistol,
    //     Gun,
    //     MeleeWeapon
    // }

    public void RefreshCurrentWeapon()
    {
        Debug.Log("Action");
        int i = (int) currentWeapon;
        if (i <= 3)
        {
            currentWeapon++;
        }
        else
        {
            currentWeapon = 0;
        }
    }
    
}
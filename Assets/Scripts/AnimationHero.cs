using UnityEngine;

public class AnimationHero : MonoBehaviour
{
    public PlayerController playerController;
    public Animator anim;
    public WeaponSwitch weaponSwitch;


    void Update()
    {
        if (playerController.joystick.direction != Vector2.zero)
        {
            anim.SetInteger("State", 1);
        }
        else
        {
            anim.SetInteger("State", 0);
        }

        CurrentGunAnimation();
    }


    void CurrentGunAnimation()
    {
        switch (weaponSwitch.currentWeapon)
        {
            case WeaponSwitch.GunType.Pistol:
                anim.SetBool("isGun", false);
                anim.SetBool("isMeleeWeapon", false);
                anim.SetBool("isPistol", true);
                break;
            case WeaponSwitch.GunType.Gun:
                anim.SetBool("isGun", true);
                anim.SetBool("isMeleeWeapon", false);
                anim.SetBool("isPistol", false);
                break;
            case WeaponSwitch.GunType.MeleeWeapon:
                anim.SetBool("isGun", false);
                anim.SetBool("isMeleeWeapon", true);
                anim.SetBool("isPistol", false);
                break;
        }
    }
    
    
}
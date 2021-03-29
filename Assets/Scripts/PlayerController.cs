using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Joystick joystick;
    public CharacterController controller;
    public Gun gun;
    public ParticleSystem muzzleFlash;
    private Animator _animator;


   
    public GameObject line;
    public LineRenderer laserLineRenderer;
    public float LaserWidth = 0.05f;
    private float Maxlength = 30f;
    public Transform transformForRay;



    [SerializeField] private WeaponSwitch _weaponSwitch;


    public float speed;
    public float gravity;
    public float firerate = 5f;
    private float nextTimeToFire = 0f;
    public bool statee;


    Vector3 moveDirection;

    private void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
        
        //for aim laser

        line = GameObject.Find("Line");
        laserLineRenderer = line.GetComponent<LineRenderer>();
        Vector3[] initLaserPositions = new Vector3[2] { Vector3.zero, Vector3.zero };
        laserLineRenderer.SetPositions(initLaserPositions);
        laserLineRenderer.SetWidth(LaserWidth, LaserWidth);
    }

    void FixedUpdate()
    {
        Move();
        if (!statee)
        {
            muzzleFlash.Play(); 
        }

        if (Time.time >= nextTimeToFire)
        {

            Debug.Log("HUi");
            nextTimeToFire = Time.time + 1f / firerate;
            Shoot(statee);
        }

        Aim();
    }

    private void Move()
    {
        Vector2 direction = joystick.direction;


        if (controller.isGrounded)
        {
            moveDirection = new Vector3(direction.x, 0, direction.y);


            Quaternion lookRotation =
                moveDirection != Vector3.zero ? Quaternion.LookRotation(moveDirection) : transform.rotation;
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);


            moveDirection = moveDirection * speed;
        }

        moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);
        controller.Move(moveDirection * Time.deltaTime);
    }

    public void Shoot(bool state)
    {
        Debug.Log(gun);
        if (state)
        {
            gun.Shoot();

        }
        
    }
    public void Aim()
    {
        Ray ray = new Ray(transformForRay.position, transformForRay.forward);
        Vector3 endPosition = transformForRay.position + (Maxlength * transformForRay.forward);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            endPosition = hit.point;

        }

        laserLineRenderer.SetPosition(0, transformForRay.position);
        laserLineRenderer.SetPosition(1, endPosition);
    }
}
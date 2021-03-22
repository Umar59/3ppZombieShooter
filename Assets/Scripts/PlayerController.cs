using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public Joystick joystick;
    public CharacterController controller;
    public Gun gun;

    private Animator _animator;


    [SerializeField] private WeaponSwitch _weaponSwitch;


    public float speed;
    public float gravity;

    public bool statee;


    Vector3 moveDirection;

    private void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        Move();
        Shoot(statee);
        
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
}
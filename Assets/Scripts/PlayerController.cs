using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public Joystick joystick;
    public CharacterController controller;

    private Animator _animator;

    private bool _pistol;
    private bool _weapon;

    [SerializeField] private WeaponSwitch _weaponSwitch;


    public float speed;
    public float gravity;


    Vector3 moveDirection;

    private void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        Vector2 direction = joystick.direction;

        
        
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(direction.x, 0, direction.y);

            Quaternion targetRotation = moveDirection != Vector3.zero
                ? Quaternion.LookRotation(moveDirection)
                : transform.rotation;
            transform.rotation = targetRotation;
            moveDirection = moveDirection * speed;
        }

        moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);
        controller.Move(moveDirection * Time.deltaTime);
    }
}
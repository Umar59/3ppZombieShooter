using UnityEngine;
using UnityEngine.UI;

public class Joystick : MonoBehaviour
{
    public RectTransform center;
    public RectTransform knob;
    public float range;
    public bool fixedJoystick;
    public Vector2 startPos;
   

    [HideInInspector] public Vector2 direction;
    

    Vector2 start;

    // void Start()
    // {
    //     ShowHide(false);
    // }

    void Update()
    {

        // Track a single touch as a direction control.
        if (Input.touchCount > 0 && Input.GetTouch(0).position.x < Screen.width/2)
        {
            Touch touch = Input.GetTouch(0);

            // Handle finger movements based on touch phase.
            switch (touch.phase)
            {
                // Record initial touch position.
                case TouchPhase.Began:
                    startPos = touch.position;
                    center.position = touch.position;
                    
                    break;

                // Determine direction by comparing the current touch position with the initial one.
                case TouchPhase.Moved:
                    direction = touch.position - startPos;
                    break;

                // Report that a direction has been chosen when the finger is lifted.
                case TouchPhase.Ended:
                    
                    direction = Vector2.zero;
                    // center.gameObject.SetActive(false);
                    // knob.gameObject.SetActive(false);
                    break;
            }

            knob.position = touch.position;
        }
        
        
        direction.Normalize();

    }

    
}
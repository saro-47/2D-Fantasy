using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public Joystick joystick;
    public GameObject analog;
    public Animator animator;

    private Vector2 movement;
    private static readonly int Horizontal = Animator.StringToHash("Horizontal");
    private static readonly int Vertical = Animator.StringToHash("Vertical");
    private static readonly int Speed = Animator.StringToHash("Speed");

    private void Update()
    {
        if (analog.activeInHierarchy)
        {
            movement.x = CrossPlatformInputManager.GetAxisRaw("Horizontal");
            movement.y = CrossPlatformInputManager.GetAxisRaw("Vertical");
        }

        if (joystick.gameObject.activeInHierarchy)
        {
            movement.x = joystick.Horizontal;
            movement.y = joystick.Vertical;
        }
        
        animator.SetFloat(Horizontal, movement.x);
        animator.SetFloat(Vertical, movement.y);
        animator.SetFloat(Speed, movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * (moveSpeed * Time.fixedDeltaTime));
    }
}

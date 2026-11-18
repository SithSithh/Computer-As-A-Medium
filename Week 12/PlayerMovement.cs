using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private float speedX = 0f;
    private float speedY = 0f;
    public Rigidbody2D rb;

    public SpriteRenderer spriteRenderer;
    public SpriteRenderer swordRenderer;

    public Sprite astronauttop;
    public Sprite astronautdown;
    public Sprite astronautleft;
    public Sprite astronautright;

    public Transform weapon;
    public Transform firePoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {

        // Horizontal Movement
        if (Keyboard.current.aKey.isPressed)
        {
            speedX = -moveSpeed;
            spriteRenderer.sprite = astronautleft;
            swordRenderer.sortingOrder = 1;
            weapon.localPosition = new Vector3(-0.59f, -1.36f, 0);
            weapon.localEulerAngles = new Vector3(0, 0, 131.69f);
            weapon.localScale = new Vector3(1, 1, 1);
            firePoint.eulerAngles = new Vector3(0, 0, 90);
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            speedX = moveSpeed;
            spriteRenderer.sprite = astronautright;
            swordRenderer.sortingOrder = 1;
            weapon.localPosition = new Vector3(0.09f, 0, 0);
            weapon.localEulerAngles = new Vector3(0, 0, 0);
            weapon.localScale = new Vector3(1, 1, 1);
            firePoint.localEulerAngles = new Vector3(0, 0, -90);
        }
        else
        {
            speedX = 0;
        }

        // Vertical Movement
        if (Keyboard.current.wKey.isPressed)
        {
            speedY = moveSpeed;
            spriteRenderer.sprite = astronauttop;
            swordRenderer.sortingOrder = -1;
            weapon.localPosition = new Vector3(-0.06f, -1.01f, 0);
            weapon.localEulerAngles = new Vector3(0, 0, 90);
            weapon.localScale = new Vector3(1, 1, 1);
            firePoint.localEulerAngles = new Vector3(0, 0, -90);
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            speedY = -moveSpeed;
            spriteRenderer.sprite = astronautdown;
            swordRenderer.sortingOrder = 1;
            weapon.localPosition = new Vector3(-0.13f, -0.14f, 0);
            weapon.localEulerAngles = new Vector3(0, 0, -90);
            weapon.localScale = new Vector3(1, 1, 1);
            firePoint.localEulerAngles = new Vector3(0, 0, -90);
        }
        else
        {
            speedY = 0;
        }

        rb.linearVelocity = new Vector2(speedX, speedY);
    }
}

using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpUp = 1f;
    public Vector3 direction;

    private Animator pAnimator;
    private Rigidbody2D pRig2D;
    private SpriteRenderer sp;
    
    void Start()
    {
        pRig2D = GetComponent<Rigidbody2D>();
        pAnimator = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
        direction = Vector2.zero;
    }

    void KeyInput()
    {
        direction.x = Input.GetAxisRaw("Horizontal");

        if (direction.x < 0)
        {
            sp.flipX = true;
        }
        else if (direction.x > 0)
        {
            sp.flipX = false;
        }
        else if (direction.x == 0)
        {
            
        }
    }

    void Update()
    {
        KeyInput();
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(moveX, 0, 0);
    }
}

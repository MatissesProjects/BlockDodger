using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce, sidewaysForce, jumpForce;
    float lastJump;
    public float jumpRestTime;

    void Start()
    {
        forwardForce = 4000f;
        sidewaysForce = 100f;
        jumpForce = 750f;
        jumpRestTime = 1.25f; // seconds
        lastJump = Time.time;
    }

    // Using fixed update as this is the physics specific version
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d")) // right
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")) // left 
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKeyDown(KeyCode.Space)) // jump
        {
            if(lastJump + jumpRestTime < Time.time) 
            {
                rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
                lastJump = Time.time;
            }
        }

    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if(rb.position.y < 0) 
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

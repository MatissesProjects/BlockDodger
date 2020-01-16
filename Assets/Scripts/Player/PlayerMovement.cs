using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce, sidewaysForce, jumpForce;
    float lastJump;
    public float jumpRestTime;
    public float levelSpeedMultiplier = 400f;

    public float forwardSpeed;

    void Start()
    {
        forwardForce = 3800f - levelSpeedMultiplier;
        sidewaysForce = 100f;
        jumpForce = 750f;
        jumpRestTime = 1.25f; // seconds
        lastJump = Time.time;
    }

    // Using fixed update as this is the physics specific version
    void FixedUpdate()
    {
        forwardSpeed = (levelSpeedMultiplier * PlayerPrefs.GetInt("level") + forwardForce) * Time.deltaTime;
        rb.AddForce(0, 0, forwardSpeed);

        if(Input.GetKey("d")) // right
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")) // left 
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey(KeyCode.Space)) // jump
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
            FindObjectOfType<GameManager>().Death("FallingSound");
        }
    }
}

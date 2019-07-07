using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello");
    }

    public float forwordforce = 1000f;
    public float Left = 500f;
    public float right = -500f;
    public float back = -20f;
    public float jump = 20f;
    public bool o = false;

    // FixUpdate is for Physics stuff
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwordforce * Time.deltaTime); 

        if(Input.GetKey("d"))
        {
            rb.AddForce(Left * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(right * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, back * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w") && o == false)
        {
            rb.AddForce(0, jump * Time.deltaTime, 0, ForceMode.VelocityChange);
            o = true;
        }

    }
}

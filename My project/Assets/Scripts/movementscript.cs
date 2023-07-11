using UnityEngine;

public class movementscript : MonoBehaviour
{
    // add rb
    public Rigidbody rb;
    public float forwardforce = 2000f;
    public float sidewayforce = 200f;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime); 

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayforce * Time.deltaTime ,0,0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayforce * Time.deltaTime ,0,0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<gamemanager>().EndGame();
        }
    }
}

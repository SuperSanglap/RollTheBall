using UnityEngine;

public class PlayerMovement : MonoBehaviour // Public Class Can be Used by Other Classes or Functions
{
    public Rigidbody rb;
    public float forwardForce = 1000F;
    public float sidewayForce = 100F;

    // Update is called once per frame
    void FixedUpdate() {
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if ( Input.GetKey("d") ) {
            rb.AddForce(sidewayForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if ( Input.GetKey("a") ) {
            rb.AddForce(-sidewayForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        
        if (rb.position.y < -1F) {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}

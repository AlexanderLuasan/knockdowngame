using UnityEngine;

public class playermovment : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 1000f;
    private string keyName = "g"
    //for pysics
    void FixedUpdate()
    {
        if (Input.GetButtonDown(keyName)) {
            rb.AddForce(0, 0, speed * Time.deltaTime)
                }
    }
}

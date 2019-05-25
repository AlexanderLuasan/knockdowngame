using UnityEngine;

public class playermovment : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 1000f;
    //for pysics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, speed * Time.deltaTime);
    }
}

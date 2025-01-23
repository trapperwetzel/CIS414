using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    protected Rigidbody rb;

    [SerializeField] protected float worldVelocity = 25;

    [SerializeField] protected Vector3 startForce = Vector3.one;
    private void FixedUpdate()
    {
        LimitBallVellocity();
    }

    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        ApplyStartForce();
    }

    protected void ApplyStartForce()
    {
        rb.AddForce(startForce, ForceMode.Impulse);

    }



    protected void LimitBallVellocity()
    {
        Vector3 hV3 = rb.velocity;
        Vector3 nV3 = Vector3.zero;

        nV3.x = Mathf.Clamp(hV3.x, -worldVelocity, worldVelocity);
        nV3.y = Mathf.Clamp(hV3.y, -worldVelocity, worldVelocity);
        nV3.z = 0;




        rb.velocity = nV3;






    }


    
}

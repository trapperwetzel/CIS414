using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Trapper W
// 02/16/2025

public class BallScript : MonoBehaviour
{
    protected Rigidbody rb;

    [SerializeField] protected float worldVelocity = 25;

    [SerializeField] protected Vector3 startForce = Vector3.one;

    [SerializeField] protected int damage = 1;
    public void FixedUpdate()
    {
        LimitBallVellocity();
    }

    public void OnEnable()
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
        nV3.z = Mathf.Clamp(hV3.z, -worldVelocity, worldVelocity);


        rb.velocity = nV3;

    }


    public void OnCollisionEnter(Collision collision)
    {
        BreakableBrick bb = collision.gameObject.GetComponent<BreakableBrick>();
        if (bb != null)
        {
            bb.Break(damage);
        }


    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooterClick : MonoBehaviour
{
    public Rigidbody projectile;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            clone.velocity = transform.TransformDirection(Vector3.forward * 500);
        }
    }
}

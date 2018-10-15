using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour {


    public float speed, rotationSpeed;

   public Rigidbody rb;

	void Start () {
        rb.GetComponent<Rigidbody>();
	}
	

	void Update () {
		
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(transform.forward * speed,ForceMode.VelocityChange);
            Debug.Log("forward boat");
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(transform.forward * -speed, ForceMode.VelocityChange);
            Debug.Log("backward boat");
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddRelativeTorque(Vector3.up * rotationSpeed, ForceMode.VelocityChange);
            Debug.Log("rotate boat right");
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddRelativeTorque(Vector3.up * -rotationSpeed, ForceMode.VelocityChange);
            Debug.Log("rotate boat left");
        }
    }
}

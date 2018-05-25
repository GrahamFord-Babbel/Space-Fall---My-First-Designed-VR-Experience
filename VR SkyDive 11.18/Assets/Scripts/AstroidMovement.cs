using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidMovement : MonoBehaviour {

    public float velocity = 300f;
    public string direction = string.Empty;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (direction == "right")
        {
            GetComponent<Rigidbody>().MovePosition(transform.position - Vector3.right * velocity * Time.deltaTime);
        }
        else
        {
            GetComponent<Rigidbody>().MovePosition(transform.position - Vector3.left * velocity * Time.deltaTime);
        }
        }
}

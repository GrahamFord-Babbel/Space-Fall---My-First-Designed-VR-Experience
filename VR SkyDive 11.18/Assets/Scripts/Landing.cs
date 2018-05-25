using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landing : MonoBehaviour {

	public void OnLanding()
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Rigidbody>().useGravity = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessfulLanding : MonoBehaviour {

    Landing landingComponent;

    void Start()
    {
        landingComponent = FindObjectOfType<Landing>();
    }
    void OnCollisionEnter(Collision collision)
    {
        landingComponent.OnLanding();
    }
}
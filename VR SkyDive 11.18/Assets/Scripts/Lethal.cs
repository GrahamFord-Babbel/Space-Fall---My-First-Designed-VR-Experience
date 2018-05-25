using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lethal : MonoBehaviour {

    Death deathComponent;

    void Start()
    {
        deathComponent = FindObjectOfType<Death>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "CameraObject")
        {
            deathComponent.OnDeath();
        }
    }
}
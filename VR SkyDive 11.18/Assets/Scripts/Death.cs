using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

    public GameObject UICanvas;
    public GameObject Reticule;
    public int astroidHit;

    public void OnDeath()
    {
        astroidHit = astroidHit + 1;
        Debug.Log("You hit an astroid:" + astroidHit);

        if (astroidHit == 3)
        {
            UICanvas.SetActive(true);
            GetComponent<Rigidbody>().useGravity = false;
            //Reticule.SetActive(true);
            Debug.Log("you've hit astroids three times, your dead" + astroidHit);
        }
    }
}

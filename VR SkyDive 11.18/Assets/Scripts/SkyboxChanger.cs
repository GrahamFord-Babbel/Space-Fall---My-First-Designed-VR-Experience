using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxChanger : MonoBehaviour {

    public LaneSpawner lanespawner;
    public int offset;
    public Material skybox1;
    public Material skybox2;
    public float skyswap;
    public float earthstop;
    public GameObject earth; 
    public float time;

    // Update is called once per frame
    void Update () {
        // neet to connect offset pub variable to this script so we can say once -600, change skybox.
        //lanespawner.GetComponent<LaneSpawner>();
        //if (offset 

        time += Time.deltaTime;
        if (time > skyswap)
        {
            RenderSettings.skybox = skybox2;
        }
        if (time > earthstop)
        {
            earth.gameObject.GetComponent<Rigidbody>().useGravity = false;
        }
    }
}
// neet to connect offset pub variable to this script so we can say once -600, change skybox.
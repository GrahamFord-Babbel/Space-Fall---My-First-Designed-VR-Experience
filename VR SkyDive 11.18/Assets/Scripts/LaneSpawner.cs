using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneSpawner : MonoBehaviour
{

    public GameObject[] safeLanePrefabs; //clouds & milkyway  ie slow particle systems
    public GameObject[] dangerousLanePrefabs; //astroids and planes
    // LaneType lastLaneType = LaneType.Safe;
    public float laneSpawnDistance = -100;
    public GameObject player;

   public int offset = -50;

    // Use this for initialization

    void Update()
    {
        // should be changed to a conditional based on time - NOT distance, as speed is always constant
        while (offset > -500 && offset > laneSpawnDistance + player.transform.position.y)
        {
           GameObject lane;
           lane =  InstantiateRandomLane(dangerousLanePrefabs);
            lane.transform.Translate(0, offset, 0);
           offset -= 50;
            print(offset);

            if (offset < -500)
            {
                lane = InstantiateRandomLane(safeLanePrefabs);
                lane.transform.Translate(0, offset, 0);
                offset -= 35;
                print(offset);

                if (offset < -1000)
                {
                    offset = -2000;
                }
            }
        }

        foreach (Transform laneTransform in transform)
        {
            if (laneTransform.position.y + laneSpawnDistance > player.transform.position.y)
            {
                Destroy(laneTransform.gameObject);
            }
        }

    }

    GameObject InstantiateRandomLane(GameObject[] lanes)
    {
        int laneIndex = Random.Range(0, lanes.Length);
        return Instantiate(lanes[laneIndex]);
    }
}
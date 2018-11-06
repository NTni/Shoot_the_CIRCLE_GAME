using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject pinPrefab;

    //public float Score =0;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SpawnPin();

        }
    }

    void SpawnPin()
    {
        Instantiate(pinPrefab, transform.position, transform.rotation);
        //Score++;
        //Debug.Log(Score);
    }

}

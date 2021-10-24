//|*************************************|
//| NAME: Phu Pham                      |
//| ID: 101250748                       |
//|                                     |
//| Script: pickupSpawner
//| Desc: Spawns picks and manages their behaviour
//| Date last modified: 24/10/2021      |
//|*************************************|

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupSpawner : MonoBehaviour
{
    public AudioSource pickupSFX;
    public GameObject pickupObj;
    public float minSpawnTime = 5;
    public float maxSpawnTime = 10;

    
    private float time;
    private bool isSpawned = false;
    // Start is called before the first frame update
    void Start()
    {
        
        time = Random.Range(minSpawnTime, maxSpawnTime);
        
    }

    // Update is called once per frame
    void Update()
    {

        if(isSpawned != true)
        {
            if (time > 0)
            {
                time -= Time.deltaTime;
            }
            else
            {
                spawnPickup();
            }

        }

    }

    //Calls when a pickup is touched
    public void onPickupTouch()
    {
        if (isSpawned == true)
        {
            pickupSFX.Play();
            GameObject.FindObjectOfType<playerManager>().gainCash();
            pickupObj.SetActive(false);
            isSpawned = false;
        }
    }

    //Spawn pickup after a set time
    public void spawnPickup()
    {
        pickupObj.SetActive(true);
        isSpawned = true;
        time = Random.Range(minSpawnTime, maxSpawnTime);
    }

    
}

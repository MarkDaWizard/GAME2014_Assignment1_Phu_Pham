//|*************************************|
//| NAME: Phu Pham                      |
//| ID: 101250748                       |
//|                                     |
//| Script: enemySpawner                |
//| Desc: Spawns a certain amount of enemies after a delay
//| Date last modified: 24/10/2021      |
//|*************************************|

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemySpawner : MonoBehaviour
{
    public int enemyCount;
    public float spawnTime=4;
    public GameObject enemyGameObject;

    public float delayTime=0;
    // Update is called once per frame
    void Update()
    {
        //Spawns enemy after timer reach 0
        if (delayTime <= 0 && enemyCount > 0)
        {
            Instantiate(enemyGameObject, transform.position, transform.rotation);
            enemyCount--;
            delayTime = spawnTime;
        }
        else if (delayTime > 0 && enemyCount > 0)
            delayTime -= Time.deltaTime;
        else if (enemyCount <= 0 && GameObject.FindGameObjectWithTag("Enemy") == null)
            SceneManager.LoadScene("MainMenuScene");
    }





}

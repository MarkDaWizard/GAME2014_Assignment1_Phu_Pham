using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretBehaviour : MonoBehaviour
{
    public GameObject buildingFX;

    public GameObject turret;
    public float buildTime = 2;
    public float range = 2;
    public float fireRate = 2;
    public float damage = 1;

    private float nextFire = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(nextFire);
        if (buildTime > 0)
        {
            
            buildTime -= Time.deltaTime;
        }
        else
        {
            buildingFX.SetActive(false);
            turret.SetActive(true);
        }

        if (turret.activeSelf)
        {
            Collider2D hitCollider = Physics2D.OverlapCircle(transform.position, range, 6);
            if (hitCollider != null)
            {
                if (nextFire > 0)
                {
                    
                    nextFire -= Time.deltaTime;
                }
                else
                {
                    hitCollider.GetComponent<MonsterBehaviourScript>().onHit(damage);
                    nextFire = fireRate;
                    
                }
            }
        }

    }

    
}

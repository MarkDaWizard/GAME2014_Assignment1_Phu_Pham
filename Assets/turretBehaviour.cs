//|*************************************|
//| NAME: Phu Pham                      |
//| ID: 101250748                       |
//|                                     |
//| Script: turretBehaviour
//| Desc: Manages turret's behaviour such as their fire rate, cost and damage
//| Date last modified: 24/10/2021      |
//|*************************************|
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretBehaviour : MonoBehaviour
{
    public GameObject buildingFX;
    public AudioSource shootSFX;
    public Transform turretHead;
    public Animator animator;

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
                turretHead.LookAt(hitCollider.transform, new Vector3(0,0,1));
                
                if (nextFire > 0)
                {
                    
                    nextFire -= Time.deltaTime;
                }
                else
                {
                    hitCollider.GetComponent<MonsterBehaviourScript>().onHit(damage);
                    nextFire = fireRate;
                    shootSFX.Play();
                    animator.SetTrigger("isShooting");
                    
                }
            }
            
        }

    }

    
}

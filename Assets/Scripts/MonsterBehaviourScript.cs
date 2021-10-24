using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBehaviourScript : MonoBehaviour
{

    public float movementSpeed;
    public float damage;
    public float health;
    public Animator animator;

    public Rigidbody2D rb;
    public Transform[] waypoints;
    private int curWaypoint;
    private Vector3 distanceFromTarget = Vector3.zero;
    private bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (curWaypoint < waypoints.Length && isDead != true)
        {
            distanceFromTarget = waypoints[curWaypoint].position - transform.position;


            if ((transform.position.x < waypoints[curWaypoint].position.x) && transform.position.y < waypoints[curWaypoint].position.y)
            {
                rb.velocity = new Vector2(movementSpeed, movementSpeed);
            }
            else if ((transform.position.x > waypoints[curWaypoint].position.x) && transform.position.y < waypoints[curWaypoint].position.y)
            {
                rb.velocity = new Vector2(-movementSpeed, movementSpeed);
            }
            else if ((transform.position.x > waypoints[curWaypoint].position.x) && transform.position.y > waypoints[curWaypoint].position.y)
            {
                rb.velocity = new Vector2(-movementSpeed, -movementSpeed);
            }
            else
            {
                rb.velocity = new Vector2(movementSpeed, -movementSpeed);
            }

            if (distanceFromTarget.magnitude < 0.5f)
            {
                curWaypoint++;
            }
        }
        else if (curWaypoint >= waypoints.Length)
        {
            GameObject.FindObjectOfType<playerManager>().onLiveLost();
            Destroy(gameObject);
        }
    }

    //Called when this monster gets hit
    public void onHit(float damage)
    {
        health -= damage;


        //Destroy monster if dead
        if (health <= 0)
        {
            isDead = true;
            animator.SetBool("IsDead", true);
            rb.velocity = Vector2.zero;
            StartCoroutine(ExecuteAfterTime(2));
        }
        else
        {
            animator.SetTrigger("isHit");
            
        }
    }

    //Destroy gameobject after a delay
    IEnumerator ExecuteAfterTime(float time)
    {

        
        yield return new WaitForSeconds(time);

        Destroy(gameObject);
    }

}

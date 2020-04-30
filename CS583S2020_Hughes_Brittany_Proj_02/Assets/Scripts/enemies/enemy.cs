using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float healthCount;
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;
    public float timeBetweenShots;
    public float startTimeBetweenShots;

    public Transform player;
    public GameObject projectile;
    public float attackRange = 5f;

 
    void Start()
    {
       // player = GameObject.FindGameObjectWithTag("Player").transform;
        timeBetweenShots = startTimeBetweenShots;
    }
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("MainPlayer").transform;
         
        if (Vector2.Distance(transform.position, player.position) <= attackRange) //formally an if loop IF NOT WORKING CHANGE TO IF 
        {
            
            if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            }
            else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
            {
                transform.position = this.transform.position;
            }
            else if (Vector2.Distance(transform.position, player.position) < retreatDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
            }

            if (timeBetweenShots <= 0)
            {
                Instantiate(projectile, transform.position, Quaternion.identity);
                timeBetweenShots = startTimeBetweenShots;
            }
            else
            {
                timeBetweenShots -= Time.deltaTime;
            }
        }
       
    }
     
   
    void OnCollisionEnter2D(Collision2D collision)
    {   
        if (collision.gameObject.tag.Equals("dagger"))
        {
            Debug.Log(healthCount);
            healthCount = healthCount - 2;
            Debug.Log(healthCount);
            Destroy(collision.gameObject);
        }
        if (healthCount <= 0)
        { 
            Destroy(this.gameObject);
            Debug.Log(healthCount + "Enemy destroyed");
        }
    }


}

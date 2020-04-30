using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private float stageCount = 0f;
    public float healthCount;
    public float beginningHealth = 10f;
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
        timeBetweenShots = startTimeBetweenShots;
        healthCount = beginningHealth;
    }
    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) <= attackRange)
        {
            player = GameObject.FindGameObjectWithTag("MainPlayer").transform;
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

    public void GameWon()
    {
        SceneManager.LoadScene("WIN");
        AudioListener.pause = true;

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("dagger"))
        {
            healthCount = healthCount - 2;
            Debug.Log(healthCount);
            Destroy(collision.gameObject);
        }
        if (healthCount <= 0)
        {
            GameWon();
        }
    }


}

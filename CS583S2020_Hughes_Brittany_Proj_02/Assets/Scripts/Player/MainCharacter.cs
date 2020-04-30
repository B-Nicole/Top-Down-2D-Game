using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MainCharacter : MonoBehaviour
{ 
    public float moveSpeed = 5f;
    public float playerHealth;
    public int numOfHearts;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public Transform firePoint;
    public GameObject daggerPrefab;

    public Rigidbody2D rb;
    public Animator animator;
    public MainManager m;

    Vector2 movement;
    public GameObject player;

    public Text coinCounter;
    private int coin;


    void Awake()
    {
        if(GameObject.FindGameObjectWithTag("Player"))
        {
            DontDestroyOnLoad(this.gameObject);
        }
        coin = 0;

    }
    void Start()
    {
        
        coinCounter.text = coin.ToString();
        //inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
    void OnEnable()
    {
        m = new MainManager();

    }
    void FixedUpdate(){
       rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
    void Update() // don't put physics in update 
    {
       movement.x = Input.GetAxisRaw("Horizontal") ;
       movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        shield();
        attack();
        // for the health containers
        if (playerHealth > numOfHearts)
        {
            playerHealth = numOfHearts;
        }
        for (int i = 0; i < hearts.Length; i++) {
            if (i < playerHealth) { 
                hearts[i].sprite = fullHeart; 
            }
            else {
                hearts[i].sprite = emptyHeart; 
            }
            if (i < numOfHearts) {
                hearts[i].enabled = true;
            }
            else {
                hearts[i].enabled = false; 
            }
           
        }//end of health for loop
      

    }
    
    public void shield()
    {
       if (Input.GetKeyDown("z") ){
            Debug.Log("shield");
            animator.SetBool("shielding", true);
        }
        animator.SetBool("shielding", false);
    }
    
    public void attack()
    {
        if (Input.GetKeyDown("space")) {
            GameObject dagger = Instantiate(daggerPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rig = dagger.GetComponent<Rigidbody2D>();
            rig.AddForce(firePoint.up * 10f, ForceMode2D.Impulse);
            Destroy(dagger, 2.0f);
            Debug.Log("dagger");
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("projectile"))
        {
            Debug.Log("In if statement for player collisions");
            playerHealth = playerHealth - 1;
            Debug.Log(playerHealth);
            Destroy(collision.gameObject);

            if (playerHealth == 0)
            {
                m.GameOver();
                //Destroy(gameObject);
                Debug.Log(playerHealth + "You Lose");
            }
        }
    
        if (collision.gameObject.CompareTag("Coin"))
        {
            coin++;
            Destroy(collision.gameObject);
            coinCounter.text = coin.ToString();
        }
        if (collision.gameObject.CompareTag("HealthPotion"))
        {
            if (playerHealth == numOfHearts)
            {
                numOfHearts++;
                playerHealth = playerHealth + 2;
                Destroy(collision.gameObject);
            }
            if (playerHealth < numOfHearts)
            {
                playerHealth = playerHealth + 2;
                Destroy(collision.gameObject);
            }
           
        }
        
    }
     

}

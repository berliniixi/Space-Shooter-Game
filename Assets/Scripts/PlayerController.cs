using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

   private Transform playerTransform;
    public int playerSpeed = 5;
    public static int playerHealth = 3;
    public static int playerScore = 0;
    float timer = 0f;
    public GameObject WeaponPrefab;
    
    
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = transform; 
        
        // position where my player start 
        playerTransform.position = new Vector3(0, -5f, 0);
        
        
    }

    // Update is called once per frame
    void Update()
    {   
        // player move left & right
        playerTransform.Translate(Vector3.right * playerSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);
        
        /// player move up & down
        
        playerTransform.Translate(Vector3.up * playerSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        
        
        // stop player goes out of range
        leftAndRight();
        upAndDown();

        // press the space bar to shoot
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Vector3 laserPosition = new Vector3(playerTransform.position.x + 0.16f, playerTransform.position.y + .99f,
                playerTransform.position.z);
            
            Instantiate(WeaponPrefab , laserPosition , Quaternion.identity);
        }

        if (Time.time - timer > 0.25f)
        {
            GetComponent<Renderer>().enabled = true;
        }
    }
    
    // function that stop the player goes out of the horizontal range
    public void leftAndRight()
    {
        if (playerTransform.position.x >= 9.32f)
        {
            playerTransform.position = new Vector3(9.32f , playerTransform.position.y, transform.position.z);

        }
        else if (playerTransform.position.x <= -9.1f)
        {
            playerTransform.position = new Vector3(-9.1f , playerTransform.position.y , transform.position.z);

        }
        
    }

    // function that stop the player goes out of the vertical range
    public void upAndDown()
    {
        if (playerTransform.position.y >= 2.5f)
        {
            playerTransform.position = new Vector3(playerTransform.position.x, 2.5f, playerTransform.position.z);
        }
        
        else if (playerTransform.position.y <= -4.5f)
        {
            playerTransform.position = new Vector3(playerTransform.position.x, -4.5f, playerTransform.position.z);
        }
    }
    
    //If the enemy collide with the enemy, the player lose health 
    void  OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("EnemyPrefab"))
        {
            GetComponent<Renderer>().enabled = false;
            timer = Time.time; 
            playerHealth--;
        }
        
        // If player lives = 0, playerObject destroyed
        //Game scene load 
        //Playre health became again 3
        if (playerHealth <=0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
            playerHealth = 3;
            
        }
    }
}

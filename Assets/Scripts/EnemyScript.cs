using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
   public static Transform enemyTransform;
       public  float minSpeed = 1.5f;
       public  float maxSpeed = 6.5f;
       public static int enemyHealth = 1;
       public static float currentSpeed;
   
       //public GameObject enemy;
       
       // Start is called before the first frame update
       void Start()
       {
           enemyTransform = transform;
   
           // Generate random position where our enemies will be spawn in x-axis
           enemyTransform.position = new Vector3( Random.Range(-7.94f , 8.18f), 5.7f, enemyTransform.position.z);
           
           // Generate random speed for our enemies
           currentSpeed = Random.Range(minSpeed, maxSpeed);
           
           
       }
   
       // Update is called once per frame
       void Update()
       {
           enemyTransform.Translate(Vector3.down * currentSpeed * Time.deltaTime);

           // if our enemies goes out the range in y-axis they automatically destroyed
           if (enemyTransform.position.y < -6.7f)
           {               
               Destroy(gameObject);
               scoreManager.instance.losePoints();   
           }
       }

       private void OnTriggerEnter2D(Collider2D collider)
       {
           if (collider.CompareTag("WeaponPrefab"))
           {
               scoreManager.instance.addPoints();
               Destroy(gameObject);
           }

           if (collider.CompareTag("Player"))
           {
               Destroy(gameObject);
               
           }
       }
}

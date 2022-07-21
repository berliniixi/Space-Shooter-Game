using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    private Transform laserTransform;

    private int laserSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        laserTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
        // Destroy the laser object when it goes out of vertical rage
        laserTransform.Translate(Vector3.up * laserSpeed * Time.deltaTime);

        if (laserTransform.position.y > 5.4f)
        {
            Destroy(gameObject);
        }

        // Destroy the enemyObject
        if (EnemyScript.enemyHealth <= 0)
        {
            Destroy(EnemyScript.FindObjectOfType<GameObject>());
            
        }
    }
}

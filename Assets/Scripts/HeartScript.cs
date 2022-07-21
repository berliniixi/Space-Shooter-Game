using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour
{
    public GameObject heart1, heart2, heart3;

    void Update()
    {
      
        if (PlayerController.playerHealth == 3)
        {

            heart1.gameObject.SetActive(true);
            heart2.gameObject.SetActive(true);
            heart3.gameObject.SetActive(true);
        }

        else if (PlayerController.playerHealth == 2)
        {

            heart1.gameObject.SetActive(true);
            heart2.gameObject.SetActive(true);
            heart3.gameObject.SetActive(false);
            PlayerController.playerHealth = 2;
        }

        else if (PlayerController.playerHealth == 1)
        {

            heart1.gameObject.SetActive(true);
            heart2.gameObject.SetActive(false);
            heart3.gameObject.SetActive(false);
            PlayerController.playerHealth = 1;
        }

        else if (PlayerController.playerHealth == 0)
        {
            heart1.gameObject.SetActive(false);
            heart2.gameObject.SetActive(false);
            heart3.gameObject.SetActive(false);
            PlayerController.playerHealth = 0;
        }
    }
}   




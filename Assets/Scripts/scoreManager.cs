using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public static scoreManager instance;
    
    
    public Text scoreText;

    private int score = 0;

    void Awake()
    {
        instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }

    public void addPoints()
    {
        score += 10;
        scoreText.text = score.ToString();
    }
    
    public void losePoints()
    {
        score -= 5;
        scoreText.text = score.ToString();
    }
}

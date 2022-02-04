using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    private TextMeshProUGUI collisionText;

    private static int i = 0;
    private static int score = 0;

    void Start()
    {
        scoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<TextMeshProUGUI>();
        collisionText = GameObject.FindGameObjectWithTag("Collision").GetComponent<TextMeshProUGUI>();
        scoreText.text = "Score: " + score;
        collisionText.text = "Food Eaten: " + i;
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        if (i == 0)
        {
            score = 3;
        }
        else
        {
            score += 5;
        }
        i++;
        ScoreDisplay();
    }

    void ScoreDisplay()
    {
        scoreText.text = "Score: " + score;
        collisionText.text = "Food Eaten: " + i;
    }
}

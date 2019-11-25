using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public Text scoreText;
    public static int playerScore;

    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
    }

    // Update is called once per frame
    public void Update()
    {
        scoreText.text = "Score: " + playerScore;
    }

    public static void GiveScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
    }
}

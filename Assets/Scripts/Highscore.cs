using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public Text highScore;
    int tempScore;

    void Start()
    {
        ScoreInput();
        highScore.text = "Highscore:" + PlayerPrefs.GetInt("Highscore", 0).ToString();
    }

    public void ScoreInput()
    {
        //GameObject Score = GameObject.Find("ScoreSystem");
        //ScoreSystem theHighScore = Score.GetComponent<ScoreSystem>();
        tempScore = ScoreSystem.playerScore;
        
        if (tempScore > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", tempScore);
            highScore.text = tempScore.ToString();
        }
    }
}

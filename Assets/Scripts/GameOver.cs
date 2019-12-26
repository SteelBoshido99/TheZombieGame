using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject PlayerUI;
    public void gameOver()
    {
        gameOverUI.SetActive(true);
        PlayerUI.SetActive(false);
        Time.timeScale = 0f;

    }





}

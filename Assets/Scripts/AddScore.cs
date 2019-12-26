using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public int score = 10;
   
    public void AddSCore()
    {
        ScoreSystem.GiveScore(score);
    }


}

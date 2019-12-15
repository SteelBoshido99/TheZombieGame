using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    public int countDownTime;
    public Text CountDown;

    private void Start()
    {
        StartCoroutine(CountDownToStart());
    }

    IEnumerator CountDownToStart()
    {
        while(countDownTime > 0)
        {
            CountDown.text = countDownTime.ToString();

            yield return new WaitForSeconds(1f);

            countDownTime-- ;

        }

        CountDown.text = "Survive!";

        
        yield return new WaitForSeconds(1f);

        CountDown.gameObject.SetActive(false);

    }







  
}

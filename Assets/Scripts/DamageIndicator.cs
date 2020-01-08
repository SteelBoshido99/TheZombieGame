using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageIndicator : MonoBehaviour
{

    public void GetHit()
    {
        damageIndicator();
    }



    IEnumerator damageIndicator()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        yield return new WaitForSeconds(1);

        GetComponent<SpriteRenderer>().color = Color.white;
        yield return new WaitForSeconds(1);
    }


    
}

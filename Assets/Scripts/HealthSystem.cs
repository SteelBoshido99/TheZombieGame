using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class OnDamagedEvent : UnityEvent<int> { }

public class HealthSystem : MonoBehaviour
{
    public int health = 10;
    public UnityEvent onDie;
    public OnDamagedEvent onDamaged;
    


    public void TakeDamage (int damage)
    {
        health -= damage;
        onDamaged.Invoke(health);


        damageIndicator();
        

        if(health == 0)
        {
            onDie.Invoke();
        }
    }

    IEnumerator damageIndicator()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        yield return new WaitForSeconds(1);

        GetComponent<SpriteRenderer>().color = Color.white;
        yield return new WaitForSeconds(1);
    }



}

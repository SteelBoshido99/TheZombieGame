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
        GetComponent<SpriteRenderer>().color = new Color(0.388235229f, 0.3372549f, 1f);
        onDamaged.Invoke(health);


        

        if(health == 0)
        {
            onDie.Invoke();
        }
    }
}

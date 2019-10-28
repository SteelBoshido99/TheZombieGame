using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 100.0f;
    public int damage = 1;


    // Start is called before the first frame update
    private void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.up * moveSpeed);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
        Die();
    }

    // Update is called once per frame
    private void OnBecameInvisible()
    {
        Die();
    }


    private void Die()
    {
        Destroy(gameObject);
    }



}

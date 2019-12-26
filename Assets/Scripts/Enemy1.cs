using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class EnemySpawnedEvent : UnityEvent <Transform> { }

public class Enemy1 : MonoBehaviour
{
    public EnemySpawnedEvent onSpawn;
   
    private void Start()
    {
        FindObjectOfType<AudioManager>().Play("ZMoan");
        GameObject player = GameObject.FindWithTag("Player");
        onSpawn.Invoke (player.transform);
    }


}
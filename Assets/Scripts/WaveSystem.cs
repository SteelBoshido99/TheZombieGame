using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSystem : MonoBehaviour
{

    public Wave[] waves;

    public float randomPos = 2; // This states the position in which the Zombies spawn between

    public int currentWaveIndex = 0; // This states the number of waves 
    public int remaining = 0; // This monitors the number of zombies remaining


    //public int ZomNumber;
    //public int ZomHealth;
    //public int ZomDamage;
    //public int WaveNum;
    //public int SpawnerNum;
    //int NowWave = 10;


    //public WaveSystem(int TheZomNum, int theZomHealth, int theWaveNum)
    //{
    //    ZomNumber = TheZomNum;
    //    ZomHealth = theZomHealth;
    //    WaveNum = theWaveNum;
    //}


    //Start is called before the first frame update
    void Start()
    {
        //WaveSystem[] NewWave = new WaveSystem[NowWave];
        Spawn();
     }


    public void OnZombieKilled()
    {
        remaining--;

        if (remaining <= 0)
        {
            currentWaveIndex++;
            Spawn();
        }
    }

    void Spawn() //A method that contains the spawning mechanism
    {
        remaining = waves[currentWaveIndex].amount;

        for (int i = 0; i < waves[currentWaveIndex].amount; i++)
        {
            float x = Random.Range(-randomPos, randomPos);
            float y = Random.Range(-randomPos, randomPos);

            Vector3 point = new Vector3(x, y, 0);


            HealthSystem health =  Instantiate(waves[0].prefab, transform.position + point, transform.rotation, transform).GetComponent<HealthSystem>();
            //---The syntax above spawns in the Zombie once it gets a message from the dead zombie that it's dead---//
            health.onDie.AddListener(OnZombieKilled);

        }
    }
}

[System.Serializable]
public struct Wave
{
    public int amount;
    public GameObject prefab;
}




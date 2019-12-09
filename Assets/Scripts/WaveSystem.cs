using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSystem : MonoBehaviour
{
       
    public int ZomNumber;
    public int ZomHealth;
    public int ZomDamage;
    public int WaveNum;
    public int SpawnerNum;
    int NowWave = 10;


    public WaveSystem(int TheZomNum, int theZomHealth, int theWaveNum)
    {
        ZomNumber = TheZomNum;
        ZomHealth = theZomHealth;
        WaveNum = theWaveNum;
    }

    // Start is called before the first frame update
    //void Start()
    //{

    ////    WaveSystem[] NewWave = new WaveSystem[NowWave];
    ////    NewWave[0] = 

       
        
    ////}

    
}

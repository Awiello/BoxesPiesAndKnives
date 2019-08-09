using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour {

    //public GameObject knife;
    public Wave[] waves;

    public Knife knife;

    public float maxWidth;
    public float minWidth;
    public float maxHeight;
    public float minHeight;
    public float maxDepth;
    public float minDepth;

    Wave currentWave;
    int currentWaveNumber;

    int knivesRemainingToSpawn;
    float nextSpawnTime;

    public GameObject knifeDestructionEffect;
    private GameObject knifeCloneFind;
    private Vector3 knifeClonePos;



    void Start() {
        NextWave();
    }

    void Update() {
        //Instantiate(knife, transform.position, transform.rotation);
        if (knivesRemainingToSpawn > 0 && Time.time > nextSpawnTime) {
            knivesRemainingToSpawn--;
            nextSpawnTime = Time.time + currentWave.timeBetweenSpawns;
            Spawn();
            //Knife spawnedKnife = Instantiate(knife, transform.position, transform.rotation);
        }

    }

    void NextWave() {
        currentWaveNumber++;
        currentWave = waves[currentWaveNumber - 1];

        knivesRemainingToSpawn = currentWave.knifeCount;

    }


    [System.Serializable]
    public class Wave{
        public int knifeCount;
        public float timeBetweenSpawns;

    }

    private void Spawn() {

        float randWidth = Random.Range(minWidth,maxWidth);
        float randHeight = Random.Range(minWidth,maxWidth);
        float randDepth = Random.Range(minDepth, maxDepth);

        Vector3 random = new Vector3(randWidth, randHeight, randDepth);
        Instantiate(knife, random, Quaternion.Euler(new Vector3(0, 0, 180)));
        knife.name = "knifeclone";
        //Instantiate(knifeDestructionEffect, knifeClonePos, Quaternion.identity);

    }

}

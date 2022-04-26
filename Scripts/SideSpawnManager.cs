using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideSpawnManager : MonoBehaviour
{

    public GameObject[] LeftAnimalPrefabs;
    private float LeftSpawnRangeZ = 15;
    private float spawnPosX = 25;
    private float starDelay = 2.0f;
    private float spawmInterval = 5.0f;

    public GameObject[] RightAnimalPrefabs;
    private float RightSpawnRangeZ = 15;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("LeftSpawnRandomAnimal", starDelay, spawmInterval);
        InvokeRepeating("RightSpawnRandomAnimal", starDelay, spawmInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void LeftSpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, LeftAnimalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnPosX, 0,Random.Range(-LeftSpawnRangeZ, LeftSpawnRangeZ));
        Instantiate(LeftAnimalPrefabs[animalIndex], spawnPos, LeftAnimalPrefabs[animalIndex].transform.rotation);
    }

    void RightSpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, RightAnimalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-spawnPosX, 0, Random.Range(-RightSpawnRangeZ, RightSpawnRangeZ));
        Instantiate(RightAnimalPrefabs[animalIndex], spawnPos, RightAnimalPrefabs[animalIndex].transform.rotation);
    }
}

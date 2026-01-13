using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float startDelay = 2f;
    [SerializeField] private float spawnInterval = 1.5f;

    [SerializeField] private GameObject[] animalPrefab;
    public float spawnRangeX = 20f;
    public float spawnPosZ = 20f;

    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }


    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPos = new Vector3(randomX, 0, spawnPosZ);
        Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);
    }
} 



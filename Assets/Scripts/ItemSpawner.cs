using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject[] weaponPickups;
    public GameObject heartPickup;

    public float weaponSpawnInterval = 8f;
    public float heartSpawnInterval = 12f;

    float weaponTimer;
    float heartTimer;

    void Update()
    {
        weaponTimer += Time.deltaTime;
        heartTimer += Time.deltaTime;

        if (weaponTimer >= weaponSpawnInterval)
        {
            SpawnRandom(weaponPickups[Random.Range(0, weaponPickups.Length)]);
            weaponTimer = 0f;
        }

        if (heartTimer >= heartSpawnInterval)
        {
            SpawnRandom(heartPickup);
            heartTimer = 0f;
        }
    }

    void SpawnRandom(GameObject prefab)
    {
        Transform p = spawnPoints[Random.Range(0, spawnPoints.Length)];
        Instantiate(prefab, p.position, Quaternion.identity);
    }
}



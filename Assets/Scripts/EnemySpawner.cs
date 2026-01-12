using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] spawnPoints;

    public float startSpawnInterval = 3f;   // 一開始幾秒一隻
    public float minSpawnInterval = 0.8f;   // 最快生成速度
    public float difficultyIncreaseTime = 30f; // 每幾秒變難

    float timer;
    float spawnInterval;

    void Start()
    {
        spawnInterval = startSpawnInterval;
        InvokeRepeating(nameof(IncreaseDifficulty), difficultyIncreaseTime, difficultyIncreaseTime);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    void SpawnEnemy()
    {
        Transform p = spawnPoints[Random.Range(0, spawnPoints.Length)];
        Instantiate(enemyPrefab, p.position, p.rotation);
        EnemySpawnCounter.Instance.AddEnemy();

    }

    void IncreaseDifficulty()
    {
        spawnInterval = Mathf.Max(minSpawnInterval, spawnInterval - 0.5f);
    }
}



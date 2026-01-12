using UnityEngine;
using UnityEngine.UI;

public class EnemySpawnCounter : MonoBehaviour
{
    public static EnemySpawnCounter Instance;

    public int totalSpawned = 0;
    public Text counterText;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void AddEnemy()
    {
        totalSpawned++;
        UpdateUI();
    }

    void UpdateUI()
    {
        if (counterText != null)
            counterText.text = "Enemies Spawned: " + totalSpawned;
    }
}


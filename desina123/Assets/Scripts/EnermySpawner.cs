using UnityEngine;

public class EnermySpawner : MonoBehaviour
{
    public GameObject enemyprefab;
    public float spawnInterval = 2f;
    public float spawnRange = 13f;

    private float timer = 0f;
    void Start()
    {
        timer += Time.deltaTime;

        if (timer < spawnInterval)
        {
            spawnEnemy();
            timer = 0f;
        }
    }

    void spawnEnemy()
    {
        Vector3 spawnposition = GetRandomEdgePosition();
        Instantiate(enemyprefab, spawnposition, Quaternion.identity);

    }
    
    void Update()
    {
        
    }
}

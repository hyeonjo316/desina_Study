using UnityEngine;

public class EnemyHealthy : MonoBehaviour
{
    public int maxHp = 3;
    public int currentHp;

    public GameObject xpprefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHp = maxHp;
    }

    public void TakeDamage(int damage)
    {
        currentHp -= damage;
        Debug.Log("맞음!");
        if (currentHp <= 0)
        {
            Die();
        }
    }
    // Update is called once per frame
    void Die()
    {
        if (xpprefab != null)
        {
            Instantiate(xpprefab, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}

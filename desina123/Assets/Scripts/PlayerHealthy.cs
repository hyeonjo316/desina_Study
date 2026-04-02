using UnityEngine;

public class PlayerHealthy : MonoBehaviour
{
    public int maxHp = 10;
    public int currentHp;

    public bool IsDead = false;


    void Start()
    {
        currentHp = maxHp;
    }

    public void TakeDamage(int damage)
    {
        if (IsDead) return;

        currentHp -= damage;

        if (currentHp <= 0)
        {
            currentHp = 0;
            Die();
        }
        Debug.Log("Player HP :" + currentHp);
    }



    void Die()
    {
        IsDead = true;
        Debug.Log("Game Over");
    }
}

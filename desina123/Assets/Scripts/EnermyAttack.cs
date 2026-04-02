using UnityEngine;

public class EnermyAttack : MonoBehaviour
{
    public int damage = 1;
    public float attackInterval = 1f;

    public float attackTimer = 0f;
    

   
    void Update()
    {
        attackTimer += Time.deltaTime;
    }
    public void OnTriggerStat(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        if (attackTimer < attackInterval) return;
        PlayerHealthy playerHealth = other.GetComponent<PlayerHealthy>();

        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);
            attackTimer = 0f;
        }
            
    }


}

using UnityEngine;

public class AutoShooter : MonoBehaviour
{
    public GameObject projecttilePrefab;
    public float attackInterval = 1f;
    public float attackRange = 10f;
    public Transform FirePoint;

    private float attackTimer = 0f;
    private PlayerHealthy playerHealthy;

    void Start()
    {
        playerHealthy = GetComponent<PlayerHealthy>();
    }

    Transform 


    void Update()
    {
        
    }
}

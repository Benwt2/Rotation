using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public int attackDamage = 5;
    public float attackInterval = 1.5f;
    public float attackRange = 1.5f;

    NavMeshAgent agent;
    Transform target;
    float attackTimer;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Teammate")?.transform;
    }

    void Update()
    {
        if (target == null) return;

        agent.SetDestination(target.position);

        float dist = Vector3.Distance(transform.position, target.position);
        if (dist <= attackRange)
        {
            attackTimer += Time.deltaTime;
            if (attackTimer >= attackInterval)
            {
                Health h = target.GetComponent<Health>();
                if (h != null)
                {
                    h.TakeDamage(attackDamage);
                }
                attackTimer = 0f;
            }
        }
        else
        {
            attackTimer = 0f;
        }
    }
}




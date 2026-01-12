using UnityEngine;

public class HeartPickup : MonoBehaviour
{
    public int healAmount = 20;

    void OnTriggerEnter(Collider other)
    {
        // 只有 Player 能撿
        if (!other.CompareTag("Player")) return;

        // 找隊友
        GameObject teammate = GameObject.FindGameObjectWithTag("Teammate");
        if (teammate == null) return;

        Health h = teammate.GetComponent<Health>();
        if (h != null)
        {
            h.Heal(healAmount);
            Destroy(gameObject);
        }
    }
}



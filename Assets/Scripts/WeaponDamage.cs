using UnityEngine;

public class WeaponDamage : MonoBehaviour
{
    public int damage = 10;

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Enemy")) return;

        Health h = other.GetComponent<Health>();
        if (h != null)
            h.TakeDamage(damage);
    }
}


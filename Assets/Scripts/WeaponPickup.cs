using UnityEngine;

public class WeaponPickup : MonoBehaviour
{
    public GameObject weaponPrefab;

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        TeamWeaponSlot slot = FindObjectOfType<TeamWeaponSlot>();
        if (slot != null)
        {
            slot.GiveWeapon(weaponPrefab);
            Destroy(gameObject);
        }
    }
}



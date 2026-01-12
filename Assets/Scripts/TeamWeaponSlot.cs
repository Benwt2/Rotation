using UnityEngine;

public class TeamWeaponSlot : MonoBehaviour
{
    public float weaponRadius = 1.5f;

    GameObject currentWeapon;

    public void GiveWeapon(GameObject weaponPrefab)
    {
        if (currentWeapon != null)
            Destroy(currentWeapon);

        currentWeapon = Instantiate(weaponPrefab);
        currentWeapon.AddComponent<WeaponOrbit>().Init(transform, weaponRadius);
    }
}




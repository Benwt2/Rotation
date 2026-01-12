using UnityEngine;

public class WeaponLifetime : MonoBehaviour
{
    public float lifeTime = 10f;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }
}


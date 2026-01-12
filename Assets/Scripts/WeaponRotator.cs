using UnityEngine;

public class WeaponRotator : MonoBehaviour
{
    public float rotateSpeed = 180f;

    void Update()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }
}


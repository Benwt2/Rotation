using UnityEngine;

public class WeaponOrbit : MonoBehaviour
{
    public float rotateSpeed = 180f;

    Transform center;
    float radius;
    float angle;

    public void Init(Transform target, float r)
    {
        center = target;
        radius = r;
        angle = Random.Range(0f, 360f);
    }

    void Update()
    {
        if (center == null) return;

        angle += rotateSpeed * Time.deltaTime;

        float rad = angle * Mathf.Deg2Rad;
        Vector3 offset = new Vector3(Mathf.Cos(rad), 0, Mathf.Sin(rad)) * radius;

        transform.position = center.position + offset;

        // 可選：面向移動方向（但不自轉）
        transform.forward = offset.normalized;
    }
}

using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHP = 100;
    public int currentHP;

    void Awake()
    {
        currentHP = maxHP;
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;
        if (currentHP <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Heal(int amount)
    {
        currentHP = Mathf.Min(currentHP + amount, maxHP);
    }
}


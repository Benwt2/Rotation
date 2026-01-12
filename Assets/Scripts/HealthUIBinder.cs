using UnityEngine;
using UnityEngine.UI;

public class HealthUIBinder : MonoBehaviour
{
    public Image fillImage;
    public MonoBehaviour healthScript; // 拖你現有的 Health 或 TeammateHealth

    int maxHP;
    int currentHP;

    void Start()
    {
        // 用反射抓欄位，不碰你原本程式
        var type = healthScript.GetType();

        maxHP = (int)type.GetField("maxHP").GetValue(healthScript);
        currentHP = (int)type.GetField("currentHP").GetValue(healthScript);

        UpdateUI();
    }

    void Update()
    {
        int newHP = (int)healthScript
            .GetType()
            .GetField("currentHP")
            .GetValue(healthScript);

        if (newHP != currentHP)
        {
            currentHP = newHP;
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        fillImage.fillAmount = (float)currentHP / maxHP;
    }
}


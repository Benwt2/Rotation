using UnityEngine;
using UnityEngine.UI;

public class UIFillDebug : MonoBehaviour
{
    public Image fill;

    void Update()
    {
        if (fill != null)
        {
            fill.fillAmount = Mathf.PingPong(Time.time, 1f);
        }
    }
}


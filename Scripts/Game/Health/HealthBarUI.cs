using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarUI : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Image _healthBarForegroungImage;

    public void UpdateHealthBar(HealthController healthController)
    {
        _healthBarForegroungImage.fillAmount = healthController.RemainingHealthPercentage;
    }
}

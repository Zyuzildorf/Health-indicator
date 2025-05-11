using UnityEngine;
using UnityEngine.UI;

public class HealthBar : HealthSliderBar
{  
    protected override void UpdateHealthIndicator(int healthValue)
    {
        HealthBar.value = (float)healthValue / Health.MaxHealth;
    }
}
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : HealthIndicator
{
    [SerializeField] private Slider _healthBar;

    protected override void UpdateHealthIndicator(int healthValue)
    {
        _healthBar.value = (float)healthValue / _health.MaxHealth;
    }
}
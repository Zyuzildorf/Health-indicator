using System;
using TMPro;
using UnityEngine;

public class HealthTextIndicator : HealthIndicator
{
    [SerializeField] private TextMeshProUGUI _healthText;

    private void Start()
    {
        _healthText.text = Convert.ToString(Health.CurrentValue + "/" + Health.MaxHealth);
    }

    protected override void UpdateHealthIndicator(int healthValue)
    {
        _healthText.text = Convert.ToString(healthValue + "/" + Health.MaxHealth);
    }
}
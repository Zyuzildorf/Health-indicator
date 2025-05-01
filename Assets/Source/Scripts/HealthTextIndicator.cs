using System;
using TMPro;
using UnityEngine;

public class HealthTextIndicator : HealthIndicator
{
    [SerializeField] private TextMeshProUGUI _healthText;

    private void Start()
    {
        _healthText.text = Convert.ToString(_health.CurrentHealth + "/" + _health.MaxHealth);
    }

    protected override void UpdateHealthIndicator(int healthValue)
    {
        _healthText.text = Convert.ToString(healthValue + "/" + _health.MaxHealth);
    }
}
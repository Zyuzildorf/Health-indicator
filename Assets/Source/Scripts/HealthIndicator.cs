using System;
using TMPro;
using UnityEngine;

public class HealthIndicator : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private TextMeshProUGUI _healthText;
    
    private void OnEnable()
    {
        _health.HealthChanged += UpdateHealthIndicator;
    }

    private void Start()
    {
        _healthText.text = Convert.ToString(_health.CurrentHealth + "/" + _health.MaxHealth);
    }

    private void OnDisable()
    {
        _health.HealthChanged -= UpdateHealthIndicator;
    }

    private void UpdateHealthIndicator(int currentHealthValue)
    {
        _healthText.text = Convert.ToString(currentHealthValue + "/" + _health.MaxHealth);
    }
}

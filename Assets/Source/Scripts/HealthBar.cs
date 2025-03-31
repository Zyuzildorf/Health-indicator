using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Slider _healthBar;

    private void OnEnable()
    {
        _health.HealthChanged += UpdateHealthBar;
    }

    private void OnDisable()
    {
        _health.HealthChanged -= UpdateHealthBar;
    }

    private void UpdateHealthBar(int healthValue)
    {
        if (_healthBar != null)
        {
            _healthBar.value = (float)healthValue / _health.MaxHealth;
        }
    }
}
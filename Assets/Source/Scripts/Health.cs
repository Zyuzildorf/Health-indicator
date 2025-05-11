using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _maxValue;

    private int _currentValue;

    public event Action Defeated;
    public event Action DamageTaken;
    public event Action<int> HealthChanged;
    
    public int MaxHealth => _maxValue;
    public int CurrentValue => _currentValue;
    
    private void Awake()
    {
        _currentValue = _maxValue;
    }
    
    public void TakeDamage(int damage)
    {
        if (damage < 0)
        {
            return;
        }
        
        if (_currentValue > 0)
        {
            _currentValue -= damage;
            HealthChanged?.Invoke(_currentValue);
            DamageTaken?.Invoke();
        }
        
        if (_currentValue <= 0)
        {
            Defeated?.Invoke();
        }
    }

    public void Recover(int healthAmount)
    {
        if (healthAmount < 0)
        {
            return;
        }

        _currentValue += healthAmount;

        if (_currentValue > MaxHealth)
        {
            _currentValue = MaxHealth;
        }
        
        HealthChanged?.Invoke(_currentValue);
    }
}
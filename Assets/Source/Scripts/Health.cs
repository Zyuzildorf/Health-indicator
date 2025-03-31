using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _health;

    public event Action Defeated;
    public event Action DamageTaken;
    public event Action<int> HealthChanged;
    
    public int MaxHealth { get; private set; }
    public int CurrentHealth => _health;

    
    private void Awake()
    {
        MaxHealth = _health;
    }
    
    public void TakeDamage(int damage)
    {
        if (damage < 0)
        {
            return;
        }
        
        if (_health > 0)
        {
            _health -= damage;
            HealthChanged?.Invoke(_health);
            DamageTaken?.Invoke();
        }
        
        
        if (_health <= 0)
        {
            Defeated?.Invoke();
        }
    }

    public void HealthRecover(int healthAmount)
    {
        if (healthAmount < 0)
        {
            return;
        }

        _health += healthAmount;

        if (_health > MaxHealth)
        {
            _health = MaxHealth;
        }
        
        HealthChanged?.Invoke(_health);
    }
}
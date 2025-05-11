using UnityEngine;

public class HealthIndicator : MonoBehaviour
{
    [SerializeField] protected Health Health;

    private void OnEnable()
    {
        Health.HealthChanged += UpdateHealthIndicator;
    }

    private void OnDisable()
    {
        Health.HealthChanged -= UpdateHealthIndicator;
    }
    
    protected virtual void UpdateHealthIndicator(int healthValue)
    {
        
    }
}
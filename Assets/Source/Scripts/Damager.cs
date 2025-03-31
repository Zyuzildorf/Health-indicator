using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private int _damageValue = 20;
    
    public void Damage()
    {
        _health.TakeDamage(_damageValue);
    }
}

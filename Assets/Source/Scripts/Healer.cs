using UnityEngine;

public class Healer : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private int _healValue = 20;
    
    public void Heal()
    {
        _health.HealthRecover(_healValue);
    }
}

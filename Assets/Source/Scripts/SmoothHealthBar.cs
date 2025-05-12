using System.Collections;
using UnityEngine;

public class SmoothHealthBar : HealthSliderBar
{
    [SerializeField] private float _duration = 2f;

    private Coroutine _currentCoroutine;

    protected override void UpdateHealthIndicator(int healthValue)
    {
        if (_currentCoroutine != null)
        {
            StopCoroutine(_currentCoroutine);
        }
        
        _currentCoroutine = StartCoroutine(ChangeHealthSmoothly(healthValue));
    }

    private IEnumerator ChangeHealthSmoothly(int targetHealth)
    {
        float targetValue = (float)targetHealth / Health.MaxHealth;
        float startValue = HealthBar.value;
        float timePassed = 0f;

        while (timePassed < _duration)
        {
            timePassed += Time.deltaTime;
            HealthBar.value = Mathf.MoveTowards(startValue, targetValue, timePassed / _duration);
            yield return null;
        }
        
        HealthBar.value = targetValue;
        _currentCoroutine = null;
    }
}
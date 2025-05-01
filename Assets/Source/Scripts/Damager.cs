public class Damager : HealthChangingButton
{
    protected override void ChangeHealthValue()
    {
        _health.TakeDamage(value);
    }
}
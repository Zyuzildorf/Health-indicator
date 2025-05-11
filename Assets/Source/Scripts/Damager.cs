public class Damager : HealthChangingButton
{
    protected override void ChangeHealthValue()
    {
        Health.TakeDamage(Value);
    }
}
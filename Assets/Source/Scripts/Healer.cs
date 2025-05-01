public class Healer : HealthChangingButton
{
    protected override void ChangeHealthValue()
    {
        _health.HealthRecover(value);
    }
}
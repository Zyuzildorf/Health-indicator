public class Healer : HealthChangingButton
{
    protected override void ChangeHealthValue()
    {
        Health.Recover(Value);
    }
}
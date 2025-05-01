using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
abstract public class HealthChangingButton : MonoBehaviour
{
    [SerializeField] protected Health _health;
    [SerializeField] protected int value;

    protected Button Button;

    protected void Awake()
    {
        Button = GetComponent<Button>();
    }

    protected void OnEnable()
    {
        Button.onClick.AddListener(ChangeHealthValue);
    }

    protected void OnDisable()
    {
        Button.onClick.RemoveListener(ChangeHealthValue);
    }

    protected virtual void ChangeHealthValue()
    {
    }
}
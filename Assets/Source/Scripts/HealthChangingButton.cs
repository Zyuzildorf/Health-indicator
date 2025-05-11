using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
abstract public class HealthChangingButton : MonoBehaviour
{
    [SerializeField] protected Health Health;
    [SerializeField] protected int Value;

    private Button Button;

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

    protected abstract void ChangeHealthValue();
}
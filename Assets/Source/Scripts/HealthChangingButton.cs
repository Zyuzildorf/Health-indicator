using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public abstract class HealthChangingButton : MonoBehaviour
{
    [SerializeField] protected Health Health;
    [SerializeField] protected int Value;

    private Button _button;

    protected void Awake()
    {
        _button = GetComponent<Button>();
    }

    protected void OnEnable()
    {
        _button.onClick.AddListener(ChangeHealthValue);
    }

    protected void OnDisable()
    {
        _button.onClick.RemoveListener(ChangeHealthValue);
    }

    protected abstract void ChangeHealthValue();    
}
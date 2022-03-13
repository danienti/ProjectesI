using UnityEngine;
using UnityEngine.Events;

public class ToggleEvent : MonoBehaviour
{
	public UnityEvent<bool> onToggle;
	public UnityEvent onOn, onOff;
	public bool on;

	public void Toggle() => Set(!on);

	public void Set(bool value)
	{
		((on = value) ? onOn : onOff)?.Invoke();
		onToggle?.Invoke(on);
	}
}

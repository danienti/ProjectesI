using UnityEngine;
using UnityEngine.Events;

public class OnDisabled : MonoBehaviour
{
	public UnityEvent onDisabled;

	void OnDisable()
	{
		onDisabled?.Invoke();
	}
}

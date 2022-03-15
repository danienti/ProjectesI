using UnityEngine;
using UnityEngine.Events;

public class OnEnabled : MonoBehaviour
{
	public UnityEvent onEnabled;

	void OnEnable()
	{
		onEnabled?.Invoke();
	}
}



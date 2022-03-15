using UnityEngine;
using UnityEngine.Events;

public class SingleEvent : MonoBehaviour
{
	public UnityEvent singleEvent;

	[ContextMenu("Invoke")]
	public void Invoke() => singleEvent?.Invoke();
}
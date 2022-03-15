using UnityEngine;
using UnityEngine.Events;

public class OnKeyPressed : MonoBehaviour
{
	public KeyCode keyCode;
	public UnityEvent onKeyPressed;
	public bool oneShot;

	void Update()
	{
		if (Input.GetKeyDown(keyCode))
		{
			onKeyPressed?.Invoke();
			if (oneShot)
				enabled = false;
		}
	}
}

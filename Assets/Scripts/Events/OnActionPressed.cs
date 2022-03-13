using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class OnActionPressed : MonoBehaviour
{
	public InputAction keyCode;
	public UnityEvent onKeyPressed;
	public bool oneShot;
	public bool skipEvents;
	private void Start()
	{
		keyCode.Enable();
		keyCode.performed += OnActionPress;
	}

	void OnActionPress(InputAction.CallbackContext ctx)
	{
		if (skipEvents) 
			return;

		if (oneShot)
			skipEvents = true;

		onKeyPressed?.Invoke();
	}

	private void OnDestroy()
	{
		keyCode.Dispose();
	}
}

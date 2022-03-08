using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[SerializeField] CharacterControl characterControl;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
			characterControl.Jump();

		int horizontal = 0;
		if (Input.GetKey(KeyCode.A))
			horizontal = -1;
		else if (Input.GetKey(KeyCode.D))
			horizontal = 1;

		characterControl.HorizontalMove(horizontal);
	}
}

using UnityEngine;

public class CharacterControl : MonoBehaviour
{
	Rigidbody2D rb;
	[SerializeField] float jumpMagnitude = 1.0f;
	[SerializeField] float speedMagnitude = 1.0f;
	bool grounded;

	private void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	private void Update()
	{
		grounded = Physics2D.Raycast(transform.position, Vector2.down, 0.6f);
		Debug.DrawLine(transform.position, transform.position + Vector3.down * 0.6f, Color.red);
	}

	public void HorizontalMove(int horizontal)
	{
		if (grounded)
			rb.AddForce(Vector3.right * horizontal * speedMagnitude);
	}

	public void Jump()
	{
		if (grounded)
			rb.AddForce(Vector3.up * jumpMagnitude);
	}
}

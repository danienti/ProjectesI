using UnityEngine;

public class PlayerController : MonoBehaviour
{
	Rigidbody2D rb;
	[SerializeField] float jumpMagnitude = 1.0f;
	[SerializeField] float speed = 1.0f;
	float horizontal = 0.0f;

	private void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
			Jump();
		if (Input.GetKey(KeyCode.A))
			horizontal = -1.0f;
		else if (Input.GetKey(KeyCode.D))
			horizontal = 1.0f;
		else
			horizontal = 0.0f;
	}

	private void FixedUpdate()
	{
		rb.velocity = new Vector3(horizontal * speed, rb.velocity.y);
	}

	void Jump()
	{
		rb.AddForce(Vector3.up * jumpMagnitude);
	}
}

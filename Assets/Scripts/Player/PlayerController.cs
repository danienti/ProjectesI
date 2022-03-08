using UnityEngine;

public class PlayerController : MonoBehaviour
{
	Rigidbody2D rb;
	[SerializeField] float jumpMagnitude = 1.0f;
<<<<<<< Updated upstream
	[SerializeField] float speedMagnitude = 1.0f;
	float horizontal = 0.0f;
=======
	[SerializeField] float movementMagnitude = 1.0f;
	[SerializeField] float horizontal = 0.0f;

>>>>>>> Stashed changes
	bool grounded;

	private void Awake()
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

		grounded = Physics2D.Raycast(transform.position, Vector2.down, 0.6f);
		Debug.DrawLine(transform.position, transform.position + Vector3.down * 0.6f, Color.red);
	}

	private void FixedUpdate()
	{
<<<<<<< Updated upstream
		if(grounded)
			rb.AddForce(Vector3.right * horizontal * speedMagnitude);
=======
		//if(horizontal != 0.0f && grounded)
		//	rb.AddForce(Vector3.right * horizontal * movementMagnitude, ForceMode2D.Impulse);
		rb.velocity = Vector3.right * horizontal * movementMagnitude;
>>>>>>> Stashed changes
	}

	void Jump()
	{
		if(grounded)
			rb.AddForce(Vector3.up * jumpMagnitude);
	}
}




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
	[SerializeField] CharacterControl characterControl;

	float timeToJump;
	[SerializeField] float minTime, maxTime;

	private void Awake()
	{
		ResetTime();
	}

	private void Update()
	{
		timeToJump -= Time.deltaTime;
		if(timeToJump <= 0.0f)
		{
			characterControl.Jump();
			ResetTime();
		}
	}

	void ResetTime() => timeToJump = Random.Range(minTime, maxTime);
}

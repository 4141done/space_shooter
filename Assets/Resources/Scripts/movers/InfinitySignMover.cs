﻿using UnityEngine;
using System.Collections;

public class InfinitySignMover : MonoBehaviour {

	public float speed;
	private int rotationDirection;
	private float timePassed = 0;
	private Vector3 originalPosition;

	void Start ()
	{
		originalPosition = GetComponent<Rigidbody> ().position;
//		float sprayAngle = (Random.value * 2 - 1) * sprayAngleRange;
//		Vector3 shootingDirection = new Vector3 (sprayAngle, 0, 1);
//		GetComponent<Rigidbody>().velocity = shootingDirection * speed;
//		this.rotationDirection = (Random.value - 0.5f > 0) ? 1 : -1;
	}

	void FixedUpdate() {
		timePassed += Time.deltaTime;
		float t = timePassed * speed;


		float x = Mathf.Sin (t); //* timePassed * speed;
		float y = Mathf.Cos (t) * Mathf.Sin (t); //* timePassed * speed;

		Vector3 newPosition = originalPosition + new Vector3 (x, 0, y);

		GetComponent<Rigidbody> ().position = newPosition;

//		Vector3 angles = transform.localEulerAngles;
//
//		Vector3 shootingDirection = new Vector3 (0, rotationDirection * 360 * time + GetComponent<Rigidbody> ().velocity.y, 0);
//		GetComponent<Rigidbody>().velocity = shootingDirection * speed;

		//transform.localEulerAngles = new Vector3 (0, rotationDirection*360*time + angles.y, 0);
	}
}

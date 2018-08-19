using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
	
	public float maxSpeed;
	public float initSpeed;
	public Rigidbody2D rb;
	
	private float currentSpeed;	

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		currentSpeed = initSpeed;
		
		rb.AddForce(Vector2.one * currentSpeed, ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Debug.Log(rb.velocity.magnitude);
		
		if (rb.velocity.magnitude > maxSpeed) 
		{
			rb.velocity = rb.velocity.normalized * maxSpeed;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
	
	public float maxSpeed;
	public float initSpeed;
	public Rigidbody2D rb;

    public float leftAngle;
    public float rightAngle;
	
	private float currentSpeed;

    private Vector2 initVector;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		currentSpeed = initSpeed;
        leftAngle = -.75f;
        rightAngle = .75f;
        initVector = new Vector2(Random.Range(leftAngle, rightAngle), Random.value);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (rb.velocity.magnitude > maxSpeed) 
		{
			rb.velocity = rb.velocity.normalized * maxSpeed;
		}

        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            transform.parent = null;

            rb.AddForce(initVector * currentSpeed 
                        / Mathf.Sqrt(Mathf.Pow(initVector.x, 2) 
                                     + Mathf.Pow(initVector.y, 2)), ForceMode2D.Impulse);
        }
	}
}

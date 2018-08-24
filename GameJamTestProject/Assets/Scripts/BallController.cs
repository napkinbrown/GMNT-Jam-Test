using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
	
	public float maxSpeed;
	public float initSpeed;
	public Rigidbody2D rb;

    public float rangeMin;
    public float rangeMax;
	
	private float currentSpeed;

    private Vector2 initVector;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		currentSpeed = initSpeed;
        rangeMin = -.75f;
        rangeMax = .75f;
        initVector = new Vector2(Random.Range(rangeMin, rangeMax), Random.value);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (rb.velocity.magnitude > maxSpeed) 
		{
			rb.velocity = rb.velocity.normalized * maxSpeed;
		}

        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            transform.parent = null;

            //rb.AddForce(new Vector2(Random.Range(-1, 1), Random.value) * currentSpeed, ForceMode2D.Impulse);
            rb.AddForce(initVector * currentSpeed 
                        / Mathf.Sqrt(Mathf.Pow(initVector.x, 2) 
                                     + Mathf.Pow(initVector.y, 2)), ForceMode2D.Impulse);
        }
	}
}

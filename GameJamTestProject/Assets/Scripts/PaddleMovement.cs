using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour {

    Rigidbody2D rb2d;
    public GameObject paddle;
    public float horizontalSpeed;

	// Use this for initialization
	void Start () {

        //paddle = GameObject.FindGameObjectWithTag("Paddle");
        horizontalSpeed = .2f;
	}

    // Update is called once per frame
    void Update()
    {
        Vector3 moveSpeed = new Vector3(horizontalSpeed, 0, 0);

        if (Input.GetKey("left") || Input.GetKey(KeyCode.A)) {
            paddle.transform.position -= moveSpeed;
        }

        if (Input.GetKey("right") || Input.GetKey(KeyCode.D))
        {
            paddle.transform.position += moveSpeed;
        }
	}
}
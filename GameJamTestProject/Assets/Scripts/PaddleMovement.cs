using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour {

    Rigidbody2D rb2d;
    public GameObject paddle;

	// Use this for initialization
	void Start () {

        rb2d = GetComponent<Rigidbody2D>();
		
	}

    // Update is called once per frame
    void Update()
    {
        
        Vector3 moveSpeed = new Vector3(5.0f, 0, 0);

        if (Input.GetKeyDown("Left") || Input.GetKeyDown("A")) {
            paddle.transform.position -= moveSpeed;
        }

        if (Input.GetKeyDown("Right") || Input.GetKeyDown("D"))
        {
            paddle.transform.position += moveSpeed;
        }
	}
}

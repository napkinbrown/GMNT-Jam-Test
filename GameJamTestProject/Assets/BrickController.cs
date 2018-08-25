using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : MonoBehaviour {

    //Possibly switch between sprites 
    public int brickHealthMax;
    private int brickHealth;

    public Sprite wornBrick;
    public Sprite nearBrokenBrick;

    private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
        brickHealth = brickHealthMax;
        spriteRenderer = GetComponent<SpriteRenderer>();
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        brickHealth--;
        if (brickHealth == 0) {
            this.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update () {

        if (brickHealth == brickHealthMax - 1) {
            spriteRenderer.sprite = wornBrick;
        } else if (brickHealth == 1) {
            spriteRenderer.sprite = nearBrokenBrick;
        }
		
	}
}

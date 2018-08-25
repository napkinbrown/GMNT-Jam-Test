using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public int lvl;
	public int playerScore;
	public int playerLives;
	
	// Use this for initialization
	void Start () {
		lvl = 1;
		playerScore = 0;
		playerLives = 3;
        	//SpawnBricks();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

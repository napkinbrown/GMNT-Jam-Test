using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public int lvl;
	public int playerScore;
	public int playerLives;
    public ObjectController objects;

	// Use this for initialization
	void Start () {
		lvl = 1;
		playerScore = 0;
		playerLives = 3;
        objects.SpawnBricks(lvl);

        //for (int y = 0; y < 5; y++)
        //{
        //    for (int x = 0; x < 5; x++)
        //    {
        //        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //        cube.AddComponent<BoxCollider2D>();
        //        cube.transform.position = new Vector3(x, y, 0);
        //    }
        //}
    }
	
	// Update is called once per frame
	void Update () {
		
	}


}

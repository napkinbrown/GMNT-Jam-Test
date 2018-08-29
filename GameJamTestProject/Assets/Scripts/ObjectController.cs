using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    GameObject paddle;
    GameObject[] bricks;
    GameObject[] balls;

    void Start()
    {
        paddle = GameObject.FindWithTag("paddle");
        bricks = GameObject.FindGameObjectsWithTag("brick");
        balls = GameObject.FindGameObjectsWithTag("ball");
        
    }

    public void destroyBrick()
    {
        //Destroy object
    }

    public void StopPaddle()
    {
        //Freeze transforms
       // paddle.StopPaddle();
    }

    public void StartPaddle()
    {
        //unfreeze paddle
    }

    public void SpawnBricks(int lvl)
    {
        //Set same number of bricks with health based on the lvl
    }

    public void StopBall()
    {
        //StopBalls
    }

    public void startBall()
    {
        //StartBalls
    }

    
}
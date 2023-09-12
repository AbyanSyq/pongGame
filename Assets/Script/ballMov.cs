using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMov : MonoBehaviour
{
    [SerializeField] private Rigidbody2D ball;
    public float ballMovspeed;
    public float ballDirection;
    private bool StartStop = true;
    void Update(){
        if (Input.GetKey(KeyCode.Space))
        {
            gameStart();
        }
    }
    void gameStart()
    {
        if (StartStop)
        {
            ball.velocity = new Vector2(ballMovspeed,ballDirection);
            StartStop = false;
        }
        
    }
    public void restartBall(){
        
        ball.velocity = new Vector2(0,0);
        ball.position = new Vector2(0,0);
        StartStop = true;
    }

}

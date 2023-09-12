using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Player;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [SerializeField]private float movSpeed;
    [SerializeField] private Rigidbody2D PlayerRB;
    void FixedUpdate()
    {
        input();
    }
    private void input(){
        if (Input.GetKey(KeyCode.UpArrow))
        {
            PlayerRB.velocity = new Vector2(0,movSpeed);
        }
        else if(Input.GetKey(KeyCode.DownArrow)){
            PlayerRB.velocity = new Vector2(0,-movSpeed);
            
        }
        else
        {
            PlayerRB.velocity = new Vector2(0,0);
        }  
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Player;
using UnityEngine;

public class playerController02 : MonoBehaviour
{
    [SerializeField]private float movSpeed;
    [SerializeField] private Rigidbody2D PlayerRB;
    void FixedUpdate()
    {
        input();
    }
    private void input(){
        if (Input.GetKey(KeyCode.W))
        {
            PlayerRB.velocity = new Vector2(0,movSpeed);
        }
        else if(Input.GetKey(KeyCode.S)){
            PlayerRB.velocity = new Vector2(0,-movSpeed);
            
        }
        else
        {
            PlayerRB.velocity = new Vector2(0,0);
        }  
    }
}

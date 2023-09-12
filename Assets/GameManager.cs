using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText01;
    public Text scoreText02;
    private int ScoreAmount01 = 0;
    private int ScoreAmount02 = 0;

    
    public void ScorePlayer01(){
        ScoreAmount01++;
        scoreText01.text = ScoreAmount01.ToString();
    }
    public void ScorePlayer02(){
        ScoreAmount02++;
        scoreText02.text = ScoreAmount02.ToString();
    }
    public void NextRound(){

    }
}

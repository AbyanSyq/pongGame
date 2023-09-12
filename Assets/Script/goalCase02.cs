using Unity.VisualScripting;
using UnityEngine;


public class goalCase02 : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D TheBall) {
        if (TheBall.tag == "Ball")
        {
            
            FindAnyObjectByType<GameManager>().ScorePlayer02();
            FindAnyObjectByType<ballMov>().restartBall();       
        
        }
    }
    
}

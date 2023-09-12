using Unity.VisualScripting;
using UnityEngine;


public class goalCase : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D TheBall) {
        if (TheBall.tag == "Ball")
        {
            
            FindAnyObjectByType<GameManager>().ScorePlayer01();
            FindAnyObjectByType<ballMov>().restartBall();       
        
        }
    }
    
}

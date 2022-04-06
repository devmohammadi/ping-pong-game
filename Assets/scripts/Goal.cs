using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // آیا گل شده است یا خیر
    public bool player1Goal;
    public GameManager gameManager;

    // اگر به برخورد کننده ها ضربه خورد چه کاری را انجام دهد
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // اگر به تگ Ball برخورد کرد
        if (collision.CompareTag("Ball"))
        {
            // اگر بازیکن اول بود 
            if (player1Goal)
            {
                // به بازیکن اول امتیاز بدهد
                gameManager.GetComponent<GameManager>().Player1Score();
            }
            else
            {
                // به بازیکن دوم امتیاز بدهد
                  gameManager.GetComponent<GameManager>().Player2Score();
            }
        }
    }
}

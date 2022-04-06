using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject ball;

    // برای بازیکن هست
    public GameObject player1;

    // برای دیوار پشت بازیکن هست
    public GameObject Player1Goal;
    public GameObject player2;
    public GameObject Player2Goal;

    // برای متنی است که اضافه کردیم
    // برای متغییر Text باید از using UnityEngine.UI; استفاده کنیم
    public Text scoreText1;
    public Text scoreText2;

    // برای نگهداری امتیاز است 
    public int scorePlayer1;
    public int scorePlayer2;

    // برای بررسی اینکه از هوش مصنوعی استفاده می کند یا خیر
    public bool AIGame;

    public int maxGameScore = 5;

    public void checkVictory()
    {
        if (scorePlayer1 == maxGameScore)
        {
            SceneManager.LoadScene("win1");
        }
        if (scorePlayer2 == maxGameScore)
        {
            SceneManager.LoadScene("win2");
        }

    }

    public void Player1Score()
    {
        // افزودن یک عدد به امتیاز بازیکن
        scorePlayer1++;
        // امتیاز را در متن قرار می دهد
        // برای تبدیل عدد به رشته از ToString() استفاده می کنیم
        checkVictory();
        scoreText1.text = scorePlayer1.ToString();
        // جایگاه قرار گیری به حالت اولیه برگردد
        ResetPosition();
    }

    public void Player2Score()
    {
        scorePlayer2++;
        checkVictory();
        scoreText2.text = scorePlayer2.ToString();
        ResetPosition();
    }

    public void ResetPosition()
    {
        // در این قسمت از متد Reset که برای توپ و بازیکن ها هست می خواهیم به صورت ارث بری استفاده کنیم
        if (AIGame)
        {
            ball.GetComponent<Ball>().Reset();
            player2.GetComponent<Players>().Reset();
        }
        else
        {
            ball.GetComponent<Ball>().Reset();
            player1.GetComponent<Players>().Reset();
            player2.GetComponent<Players>().Reset();
        }
    }

}

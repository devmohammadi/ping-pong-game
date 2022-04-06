using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// برای مدیریت صحنه
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void onePlayer()
    {
        // نام صحنه مورد نظر را برای لود کردن می نویسیم
        SceneManager.LoadScene("PlayerVsAI");
    }

    public void towPlayer()
    {
        SceneManager.LoadScene("PlayerVsPlayer");
    }

}

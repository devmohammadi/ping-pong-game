using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VectoryScenes : MonoBehaviour
{
    void Start()
    {
        // با استفاده از این کد می توانیم بعد از مدت زمانی متدی را فراخوانی کنیم
        Invoke("LoadScene" , 3);
    }


    public void LoadScene()
    {
        SceneManager.LoadScene("Menu");
    }
}

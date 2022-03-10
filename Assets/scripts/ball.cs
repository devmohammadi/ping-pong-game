using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 7;
    public Rigidbody2D rb;
    private Vector2 startPosition;
    void Start()
    {
        startPosition = transform.position;
        Launch();
    }

    public void Reset()
    {
        transform.position = startPosition;
        rb.velocity = Vector2.zero;
        Launch();
    }

    public void Launch()
    {
        // به صورت تصادفی عددی از 0 تا 1 برای ما در نظر می گیرد
        // به صورت تصادفی موقعیتی را برای توپ در نظر می گیرد 
        // مختصات نموداری از 1 تا منفی 1 است 
        // اگر عدد تصادفی صفر بود موقعیت را برابر منفی 1 قرار دهد در غیر این صورت یک
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        // شتاب توپ را با سرعتی که مشخص کردیم تنظیم می کنیم
        rb.velocity = new Vector2(speed * x, speed * y);
    }

}

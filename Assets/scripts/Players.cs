using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public bool player1; // آیا بازیکن اول هست یا خیر
    public float speed = 3; // سرعت اجرا
    public Rigidbody2D rb; // جسمی که می خواهیم به آن حرکت و انیمیشن بدهیم
    private float move;
    private Vector2 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        // جابه جایی شی ، لحظه شروع بازی از این مقدار می خواند و موقعیت را قرار می دهد
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // اگر بازیکن اول بود با استفاده از آیتم Vertical1 حرکت را کنترل کن و در غیر این صورت با Vertical2 حرکت را مدیرت کن
        if (player1)
        {
            move = Input.GetAxisRaw("Vertical1");
        }
        else
        {
            move = Input.GetAxisRaw("Vertical2");
        }

        // میزان شتاب محور x را مدیریت می کنیم
        // آیتم وقتی جابه جا شئ با سرعت که مشخص شده است در محور x جا به جا می شود
        rb.velocity = new Vector2(rb.velocity.x, move * speed);
    }

    public void Reset()
    {
        // شتاب را برابر صفر قرار می دهیم
        rb.velocity = Vector2.zero;

        // موقعیت را برابر مقدار اولیه قرار می دهیم
        transform.position = startPosition;
    }

}

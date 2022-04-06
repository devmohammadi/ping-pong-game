using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{

    public float speed = 3;
    public GameObject ball;
    public Vector2 ballPosition;

    void Update()
    {
        Move();
    }

    public void Move()
    {
        // جابه جایی و موقعیت در محور x و y
        // موقعیت توپ را دریافت می کند
        ballPosition = ball.transform.position;

        // اگر موقعیت بزرگتر از توپ بود
        if (transform.position.y > ballPosition.y)
        {
            // deltaTime یعنی فاصله و اختلاف زمانی که وجود دارد
            //  اگر موقعیتی که توپ دارد بیشتر از موقعیت بازیکن بود بیایید پایین  
            transform.position += new Vector3(0, -speed * Time.deltaTime);
        }

        // اگر موقعیت کوچکتر از توپ بود
        if (transform.position.y < ballPosition.y)
        {
            //  اگر موقعیتی که توپ دارد کمتر از موقعیت بازیکن بود برود بالا  
            transform.position += new Vector3(0, speed * Time.deltaTime);
        }
    }
}

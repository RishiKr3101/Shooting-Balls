using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShakeController : MonoBehaviour
{
    private float shaketimeremaining, shakepower, shakefadetime;
    float length= 0.2f, power=0.3f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        Vector3 playerpos = transform.position;
        if(shaketimeremaining>0)
        {
            shaketimeremaining -= Time.deltaTime;
            float xAmt = Random.Range(playerpos.x-0.2f, playerpos.x+0.2f);
            float yAmt = Random.Range(playerpos.y-0.2f, playerpos.y+0.2f);

            transform.position = new Vector3(xAmt, yAmt, 0f);
            shakepower = Mathf.MoveTowards(shakepower, 0f, Time.deltaTime);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "points")
        {
            shaketimeremaining = length;
            shakepower = power;
            shakefadetime = power / length;


        }
        if (collision.gameObject.tag == "Finish")
        {
            shaketimeremaining = length;
            shakepower = power;
            shakefadetime = power / length;
        }

    }
}


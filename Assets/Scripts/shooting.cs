using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    Rigidbody2D rb;
    LineRenderer lr;
    Camera cam;
    Vector2 mousepress;
    Vector2 mouserelease;
    Vector2 direction = Vector2.zero;
    Vector3 camoffset = new Vector3(0, 0, 10);
    Vector3 startpos;
    Vector3 endpos;

    [SerializeField] AnimationCurve ac;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (lr == null)
            {
                lr = gameObject.AddComponent<LineRenderer>();
            }
            lr.enabled = true;
            lr.positionCount = 2;
            startpos = cam.ScreenToWorldPoint(Input.mousePosition) + camoffset;
            lr.SetPosition(0, startpos);
            lr.useWorldSpace = true;
            lr.widthCurve = ac;
            lr.numCapVertices = 10;

            mousepress = Input.mousePosition;
            

        }

        if (Input.GetMouseButton(0))
        {
            endpos = cam.ScreenToWorldPoint(Input.mousePosition) + camoffset;
            lr.SetPosition(1, endpos);
        }

            if (Input.GetMouseButtonUp(0))
        {
            lr.enabled = false;
            mouserelease = Input.mousePosition;
            direction = mousepress - mouserelease;
            rb.AddForce(direction * 2);
        }

    }
    private void FixedUpdate()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.AddForce(Vector3.zero);
    }
}

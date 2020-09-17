using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class collide : MonoBehaviour
{
    Vector2 dir;
    int score;
    
    [SerializeField] private GameObject obj;
    
    
    
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

    public void OnCollisionEnter2D(Collision2D collision)
    {
        rb.AddForce(Vector2.zero);
        if (collision.gameObject.tag == "points")
        {
            
            Destroy(collision.gameObject);
            Instantiate(obj, transform.position, Quaternion.identity);
            dir.y = rb.position.y;
            rb.AddForce(dir * 50);
            score++;
            
        }
        if(collision.gameObject.tag == "Finish")
        {
            Instantiate(obj, transform.position, Quaternion.identity);
            Destroy(rb);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }
}

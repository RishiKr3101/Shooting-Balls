using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public GameObject Objfol;
    public float speed = 2.0f;
    void Update()
    {
        float interpolation = speed + Time.deltaTime;
        Vector3 position = this.transform.position;
        position.y = Mathf.Lerp(this.transform.position.y, Objfol.transform.position.y, interpolation);
        position.x = Mathf.Lerp(this.transform.position.x, Objfol.transform.position.x, interpolation);
        this.transform.position = position;
    }
}

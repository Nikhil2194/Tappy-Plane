using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5f;
    private float leftedge;


    private void Start()
    {
        leftedge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;   //calculating size for destrotying game object
    }
    private void Update()
    {
        transform.position = transform.position + Vector3.left * speed * Time.deltaTime;

        if(transform.position.x <= leftedge)
        {
            Destroy(gameObject);
        }
    }

    
}

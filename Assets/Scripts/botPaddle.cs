using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class botPaddle : MonoBehaviour
{

    public float yPosition = 0f;
    public float yDirection = 3f;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //// Update is called once per frame
    //void Update()
    //{
    //    yPosition = yPosition + yDirection * Time.deltaTime;
    //    transform.position = new Vector3(transform.position.x, yPosition, 0f);
    //}
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.CompareTag("HorizontalWall")) {
    //        yDirection = yDirection * -1f;
    //    }
    //}

    private void Update()
    {
        transform.position = new Vector3(transform.position.x,ball.transform.position.y, 0f);   
    }
}

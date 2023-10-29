using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class botPaddleMEDown : MonoBehaviour
{

    public float yPosition = 0f;
    public float xPosition = 0f;
    public float yDirection = 3f;
    public float maxValue = -3.75f;
    public float minValue = 0f;
    public GameObject ball;
    public GameObject paddleL;
    public GameObject paddleR;
    public float speed = 5f;
    public float botYPosition = 0f;
    public float botXPosition;
    public string leftOrRight;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
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

    void Update()
    {
        Botpaddle();
    }

    void Botpaddle()
    {
        transform.position = new Vector3(botXPosition, botYPosition, 0f);
        //transform.position = new Vector3(transform.position.x, ball.transform.position.y, 0f);
        if (ball.transform.position.y > paddleR.transform.position.y && transform.position.y < minValue)
        {
            botYPosition += 6f * Time.deltaTime;
        }
        else if (ball.transform.position.y < paddleR.transform.position.y && transform.position.y > maxValue)
        {
            botYPosition += -6f * Time.deltaTime;
        }
    }
}
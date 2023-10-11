using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Collision : MonoBehaviour
{
    public float xPosition = 0f;
    public float yPosition = 0f;
    public float xDirection = 1.37f; //speed X
    public float yDirection = 2.2f; //speed Y
    private GameObject scoreGameObject;
    private TMPro.TMP_Text scoreboard;
    private int player1Score;
    private int player2Score;

    // Start is called before the first frame update
    void Start()
    {
        scoreGameObject = GameObject.Find("score");
        scoreboard = scoreGameObject.GetComponent<TMPro.TMP_Text>();

        transform.position = new Vector3(xPosition, yPosition, 0f);   
    }

    // Update is called once per frame
    void Update()
    {
        xPosition = xPosition + xDirection * Time.deltaTime;
        //xPosition += xDirection*Time.deltaTime; = Shorter Version
        yPosition = yPosition + yDirection * Time.deltaTime;
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Goal")) // Goal 1 reset speed
        {
            xPosition = 0f;
            yPosition = 0f;
            xDirection = 1.37f; 
            yDirection = 2.2f;
            player2Score++;
        }
        if(collision.gameObject.CompareTag("Goal2")) // Goal 2 reset speed
        {
            xPosition = 0f;
            yPosition = 0f;
            xDirection = 1.37f; 
            yDirection = 2.2f;
            player1Score++;
        }
        Debug.Log("Auw!");
        if(collision.gameObject.CompareTag("HorizontalWall")) // Y times
        {
            Debug.Log("my head or my feet");
            yDirection = yDirection * -1f;
        }else if(collision.gameObject.CompareTag("VerticalWall")) // X times
        {
            Debug.Log("my butt or my crotch");
            xDirection = xDirection * -1.393f;
            yDirection = yDirection * 1.278f;
        }
    }
    private void LateUpdate()
    {
        scoreboard.text = player1Score.ToString() + " - " + player2Score.ToString();
    }
}

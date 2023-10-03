using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public float xPosition = 2f;
    public float yPosition = 2f;
    public float xDirection = 1f; //speed X
    public float yDirection = 2f; //speed Y

    // Start is called before the first frame update
    void Start()
    {
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
        Debug.Log("Auw!");
        if(collision.gameObject.CompareTag("HorizontalWall"))
        {
            Debug.Log("my head or my feet");
            yDirection = yDirection * -1f;
        }else if(collision.gameObject.CompareTag("VerticalWall"))
        {
            Debug.Log("my butt or my crotch");
            xDirection = xDirection * -1f;
        }
    }
}

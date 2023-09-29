using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementBallScript : MonoBehaviour
{
    public float xPosition = 2f;
    public float yPosition = 2f;
    public float xDirection = 1f;
    public float yDirection = 1f;

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
        yPosition = xPosition + yDirection * Time.deltaTime;
        transform.position = new Vector3(xPosition, yPosition, 0f);

        
    }
}

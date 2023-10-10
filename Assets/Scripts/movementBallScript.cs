using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementBallScript : MonoBehaviour
{
    public float xPosition = 0f;
    public float yPosition = 0f;
    public float xDirection = 1.5f;
    public float yDirection = 1.3f;
    public int lOrR = 0;
    public int lOrR2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        var lOrR = Random.Range(0, 2);
        if(lOrR == 0)
        {
            yDirection = yDirection * -1f;
        }

        var lOrR2 = Random.Range(0, 2);
        if(lOrR2 == 0)
        {
            xDirection = xDirection * -1f;
        }





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

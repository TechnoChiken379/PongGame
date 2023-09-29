using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementBallScript : MonoBehaviour
{
    public float xPosition = 2f;
    public float yPosition = 2f;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);    
    }
}

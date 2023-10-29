using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddlleScriptDown : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 6f;
    public string leftOrRight;
    public float maxValue = -3.8f;
    public float minValue = 0f;

    void paddlleControl(KeyCode up,KeyCode down)
    {
        if (Input.GetKey(up) && transform.position.y < minValue)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);

        }
        else if (Input.GetKey(down) && transform.position.y > maxValue)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }
    


    // Update is called once per frame
    void Update()
    {
        if (leftOrRight == "left")
        {
            paddlleControl(KeyCode.Mouse0,KeyCode.Mouse1);
        }else if (leftOrRight == "right")
        {
            paddlleControl(KeyCode.UpArrow, KeyCode.DownArrow);
        }
        
    }
}

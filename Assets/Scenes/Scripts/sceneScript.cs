using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class sceneScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("pvpPong");
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("bPongEZ");
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            SceneManager.LoadScene("bPongME");
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            SceneManager.LoadScene("bPongHA");
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            SceneManager.LoadScene("bPongNM");
        }
        if (Input.GetKey(KeyCode.Alpha6))
        {
            SceneManager.LoadScene("specialeMenu");
        }
        if (Input.GetKey(KeyCode.Alpha7))
        {
            SceneManager.LoadScene("kysMode");
        }

    }

}


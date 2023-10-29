using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class sceneScriptSpecialePong : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("pvpPong1v2");
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("pvpPong2v1");
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            SceneManager.LoadScene("pvpPong2vBot");
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            SceneManager.LoadScene("pvpPongBotv2");
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            SceneManager.LoadScene("pvpPong2v2");
        }
        if (Input.GetKey(KeyCode.Alpha6))
        {
            SceneManager.LoadScene("pvpPong0v0");
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }

    }

}


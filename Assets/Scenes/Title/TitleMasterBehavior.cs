using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMasterBehavior : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    void FixedUpdate()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}
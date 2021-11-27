using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceStart : MonoBehaviour
{

  // Use this for initialization
  void Start()
  {

  }

  void FixedUpdate()
  {
    if (Input.GetKey(KeyCode.Space))
    {
      SceneManager.LoadScene("MainScene");
    }
  }
}
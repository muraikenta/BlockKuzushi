// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

  // Use this for initialization
  void Start()
  {
    Application.targetFrameRate = 30;

  }

  void FixedUpdate()
  {
    if (Input.GetKey(KeyCode.LeftArrow))
    {
      transform.position += transform.forward * 0.2f;
    }
    else if (Input.GetKey(KeyCode.RightArrow))
    {
      transform.position -= transform.forward * 0.2f;
    }
  }
}
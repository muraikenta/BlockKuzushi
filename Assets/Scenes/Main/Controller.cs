using UnityEngine;
using Zenject;

public class Controller : MonoBehaviour
{
    [Inject]
    InputProvider inputProvider;

    // Use this for initialization
    void Start()
    {
        Application.targetFrameRate = 30;
    }

    void FixedUpdate()
    {
        transform.position -= transform.forward * inputProvider.move() * 0.2f;
    }
}
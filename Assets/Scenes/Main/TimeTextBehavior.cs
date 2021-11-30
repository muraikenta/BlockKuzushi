using System;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

public class TimeTextBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameState.time.ThrottleFirst(TimeSpan.FromMilliseconds(100)).Subscribe(value =>
        {
            gameObject.GetComponent<Text>().text = $"Time: {value.ToString("F1")}s";
        }).AddTo(gameObject);
    }
}

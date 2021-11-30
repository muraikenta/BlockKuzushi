using UnityEngine;
using UniRx;
using UnityEngine.UI;

public class ScoreTextBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameState.score.Subscribe(value =>
        {
            gameObject.GetComponent<Text>().text = $"Score: {value}";
        }).AddTo(gameObject);
    }
}

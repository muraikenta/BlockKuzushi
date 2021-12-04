using UnityEngine;
using UnityEngine.UI;

public class TitleBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // if (GameState.score.Value >= Constants.BlockCount)
        if (GameState.score.Value >= Constants.BlockCount)
        {
            gameObject.GetComponent<Text>().text = "ゲームクリア！";
        }
        else
        {
            gameObject.GetComponent<Text>().text = "ゲームオーバー...";
        }

    }
}

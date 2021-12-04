using UnityEngine;

public class ResultMasterBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GameState.score.Value >= Constants.BlockCount)
        {
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
}

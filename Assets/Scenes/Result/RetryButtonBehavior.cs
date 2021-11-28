using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButtonBehavior : MonoBehaviour
{
    public void onClick()
    {
        SceneManager.LoadScene("MainScene");
    }
}

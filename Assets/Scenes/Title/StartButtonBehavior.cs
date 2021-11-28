using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonBehavior : MonoBehaviour
{
    public void onClick()
    {
        SceneManager.LoadScene("MainScene");
    }
}

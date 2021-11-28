using UnityEngine;
using UnityEngine.SceneManagement;

public class StopButtonBehavior : MonoBehaviour
{
    public void onClick()
    {
        Debug.Log("Button tapped");
        Debug.Log(SceneManager.sceneCount.ToString());
        SceneManager.LoadScene("TitleScene");
    }
}

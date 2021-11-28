using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultMasterBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void FixedUpdate()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}

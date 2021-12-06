using UnityEngine;

public class KabeOut : MonoBehaviour
{
    [SerializeField] bool disabled = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (disabled) return;
        GameObject.Find("Master").GetComponent<GameMaster>().GameOver();
    }
}
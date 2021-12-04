using UnityEngine;
public class BallBehavior : MonoBehaviour
{

    float minXSpeed = 3f;
    float minZSpeed = 3f;

    // Use this for initialization
    void Start()
    {
        transform.eulerAngles = new Vector3(0, Random.Range(30, 120), 0);
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
    }

    // Update is called once per frame
    void Update()
    {
        this.ApplyMinSpeed();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Block") return;
        gameObject.GetComponent<AudioSource>().Play();
        GameState.score.Value++;
        Destroy(collision.gameObject);
    }

    void ApplyMinSpeed()
    {
        Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
        Vector3 velocity = rigidbody.velocity;
        if (Mathf.Abs(velocity.x) < minXSpeed)
        {
            int direction = velocity.x > 0 ? 1 : -1;
            velocity.x = direction * minXSpeed;
            rigidbody.velocity = velocity;
        }
        if (Mathf.Abs(velocity.z) < minZSpeed)
        {
            int direction = velocity.z > 0 ? 1 : -1;
            velocity.z = direction * minZSpeed;
            rigidbody.velocity = velocity;
        }
    }
}
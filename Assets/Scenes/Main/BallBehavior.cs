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


    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Block":
                OnCollisionEnterBlock(collision);
                break;
            default:
                return;
        }
    }

    void OnCollisionExit(Collision collision)
    {

        switch (collision.gameObject.tag)
        {
            case "Player":
                OnCollisionExitPlayer(collision);
                break;
            default:
                return;
        }
    }

    void OnCollisionEnterBlock(Collision collision)
    {
        gameObject.GetComponent<AudioSource>().Play();
        GameState.score.Value++;
        Destroy(collision.gameObject);
    }

    void OnCollisionExitPlayer(Collision collision)
    {
        var delta = 5;
        var rb = gameObject.GetComponent<Rigidbody>();

        // debug時にPlayerの下側に衝突したときは無視
        if (rb.velocity.x < 0) return;

        // // TODO: joystick対応
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // 左方向に進行方向を回転
            rb.velocity = Quaternion.Euler(0, -30, 0) * rb.velocity;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // 右方向に進行方向を回転
            rb.velocity = Quaternion.Euler(0, 30, 0) * rb.velocity;
        }
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
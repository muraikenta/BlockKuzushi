using UnityEngine;

public class BlockBehavior : MonoBehaviour
{
    [SerializeField] GameObject effect;
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(effect, transform.position, Quaternion.identity);
    }
}
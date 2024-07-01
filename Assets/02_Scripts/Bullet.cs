using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed = 1500.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.forward * speed);
    }
}

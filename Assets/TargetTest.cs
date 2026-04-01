using UnityEngine;

public class TargetTest : MonoBehaviour
{
    public float Speed = 1f;
    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        _rb.linearVelocity = transform.right * Speed;
    }
}

using UnityEngine;

public class CameraTest : MonoBehaviour
{
    public float Speed = 1f;

    private void Update()
    {
        transform.position += transform.right * Speed * Time.deltaTime;
    }
    private void LateUpdate()
    {

    }
}

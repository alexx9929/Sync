using System;
using System.Linq;
using UnityEngine;

public class CameraTest : MonoBehaviour
{
    public float Speed = 1f;
    private float[] buffer = new float[5];
    public Transform target;

    private void Update()
    {
/*        var t = buffer.Average();
        transform.position += transform.right * Speed * t;*/

        Array.Copy(buffer, 1, buffer, 0, buffer.Length - 1);
        buffer[buffer.Length - 1] = Time.deltaTime;
    }
    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, buffer.Average());
    }
}

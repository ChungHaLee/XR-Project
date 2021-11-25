using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotate : MonoBehaviour
{
    public float Speed = 0.7f;

    void Update()
    {
        transform.Rotate(new Vector3(100, 0, 0) * Speed * Time.deltaTime);
    }
}

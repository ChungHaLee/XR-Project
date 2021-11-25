using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarriageMove : MonoBehaviour
{
    public float Speed = 0.7f;

    void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }
}

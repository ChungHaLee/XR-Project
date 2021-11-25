using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelControl : MonoBehaviour
{
    public float Speed = 0.7f;

    void Update()
    {
        while (true)
        {
            transform.Rotate(new Vector3(20, 0, 0) * Speed * Time.deltaTime);
            transform.Rotate(new Vector3(-20, 0, 0) * Speed * Time.deltaTime);
        }
        
    }
}

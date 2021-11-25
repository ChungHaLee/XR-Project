using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusMove : MonoBehaviour
{
    public int Speed = 10;
    public GameObject bus;
    public GameObject busStop;

    private float distance;

    void Update()
    {
        transform.Translate(Vector3.back * Speed * Time.deltaTime);
        distance = Vector3.Distance(bus.transform.position, busStop.transform.position);
        if (distance <= 4)
        {
            Speed = 0;
        }
    }
}

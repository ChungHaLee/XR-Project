using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleWalk : MonoBehaviour
{
    public int Speed = 1;

    void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseAnimation : MonoBehaviour
{
    private Animation anim;
    public float Speed = 0.7f;

    void Start()
    {
        anim = GetComponent<Animation>();   
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        anim.Play("Tarsus");
    }
}

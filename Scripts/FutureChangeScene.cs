using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FutureChangeScene : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(countTime());
    }

    IEnumerator countTime()
    {
        yield return new WaitForSeconds(10);
    }
}

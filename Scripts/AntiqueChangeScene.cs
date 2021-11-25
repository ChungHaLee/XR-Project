using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AntiqueChangeScene : MonoBehaviour
{
    public AudioSource audio;

    void Start()
    {
        StartCoroutine(countTime());
    }

    IEnumerator countTime()
    {
        yield return new WaitForSeconds(7);
        //audio.Pause();
        SceneManager.LoadScene("Modern");
    }
}

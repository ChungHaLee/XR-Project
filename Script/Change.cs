using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour
{
    public void toMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void toIndustry()
    {
        SceneManager.LoadScene("industry");
    }

    public void toKorea()
    {
        SceneManager.LoadScene("korea");
    }
}

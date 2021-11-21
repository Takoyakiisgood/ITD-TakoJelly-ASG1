using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashPage : MonoBehaviour
{
    /// <summary>
    /// The time to wait before it transit to another scene
    /// </summary>
    public float transitionTime;

    void Start()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelindex)
    {
        //wait
        yield return new WaitForSeconds(transitionTime);
        //Load scene
        SceneManager.LoadScene(levelindex);
    }
}

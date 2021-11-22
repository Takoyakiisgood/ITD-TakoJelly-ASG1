using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{  
    //for progress bar
    public bool hasMask;
    public bool hasShield;
    public bool hasSanitizer;

    //to see which poster it is
    // 1 symptoms, 2 exercise, 3 dining
    public int PosterInt = 0;

    //0 is mask, 1 is faceshield, 2 is hand sanitizer
    public int StageInt =-1;

    /// <summary>
    /// set the GameManager as an instance to allow it to be called on multiple scripts
    /// </summary>
    public static GameManager instance;

    private void Awake()
    {        
        //check if the instance has not been created if there is destroy it
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        hasMask = true;
        hasShield = true;
        hasSanitizer = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Quit()
    {
        Application.Quit();
    }

    //index 0 is splashScene, 1 is MainScene, 2 is AR Camera, 3 is QuestionScene, 4 is ViewModelScene
    public void mainScene()
    {
        //Load scene
        SceneManager.LoadScene(1);
    }

    public void arCamera()
    {
        //Load scene
        SceneManager.LoadScene(2);
    }

    public void QuestionScene()
    {
        //Load scene
        SceneManager.LoadScene(3);
    }

    public void ViewModelScene()
    {
        SceneManager.LoadScene(4);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageTracker : MonoBehaviour
{   
    public Text debug;
    public GameManager gm;

    public Button quizBtn;

    private void Awake()
    {
        gm = GameManager.instance;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (quizBtn != null)
        {
            quizBtn.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GoBack()
    {
        gm.mainScene();
    }

    public void StartQuiz()
    {
        gm.QuestionScene();
    }

    public void PosterTracked(GameObject objectToTrack)
    {
        debug.text = "You have found " + objectToTrack.name;
        //set the quizbtn to true only if a poster is found
        if (quizBtn != null)
        {
            quizBtn.gameObject.SetActive(true);
        }

        if (objectToTrack.name == "Symptoms of Covid-19 Poster")
        {
            gm.PosterInt = 1;
        }

        if (objectToTrack.name == "Etiquette for Exercise Poster")
        {
            gm.PosterInt = 2;
        }

        if (objectToTrack.name == "Safe Dinning Poster")
        {
            gm.PosterInt = 3;
        }
    }

    public void PosterLost()
    {
        debug.text = "No Poster Found Yet";
        //set the quizbtn to true only if a poster is found
        if (quizBtn != null)
        {
            quizBtn.gameObject.SetActive(false);
        }
    }
}

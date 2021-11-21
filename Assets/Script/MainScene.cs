using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainScene : MonoBehaviour
{
    public GameManager gm;

    public Slider progressBar;
    public int progressValue;

    public Button viewMask;
    public Button viewShield;
    public Button viewSanitizer;

    public GameObject rewardsPage;

    private void Awake()
    {
        gm = GameManager.instance;
    }

    void Start()
    {
        progressValue = 0;
        CheckCollectables();
        UpdateProgressBar();
    }

    private void Update()
    {
        
    }

    //0 is mask, 1 is faceshield, 2 is hand sanitizer
    public void MaskCollectable()
    {
        //set the Stage Int and load to the view model scene
        gm.StageInt = 0;
        //Debug.Log("StageInt =" + StageInt);
        gm.ViewModelScene();
    }

    public void ShieldCollectable()
    {
        //set the Stage Int and load to the view model scene
        gm.StageInt = 1;
        //Debug.Log("StageInt =" + StageInt);
        gm.ViewModelScene();
    }

    public void SanitizerCollectable()
    {
        //set the Stage Int and load to the view model scene
        gm.StageInt = 2;
        //Debug.Log("StageInt =" + StageInt);
        gm.ViewModelScene();
    }

    public void CheckCollectables()
    {
        //if user has mask will set button to be interactable
        if (gm.hasMask == true)
        {
            viewMask.interactable = true;
            progressValue++;
        }
        else
        {
            viewMask.interactable = false;
        }

        //if user has Face Shield will set button to be interactable
        if (gm.hasShield == true)
        {
            viewShield.interactable = true;
            progressValue++;
        }
        else
        {
            viewShield.interactable = false;
        }

        //if user has Sanitizer will set button to be interactable
        if (gm.hasSanitizer == true)
        {
            viewSanitizer.interactable = true;
            progressValue++;
        }
        else
        {
            viewSanitizer.interactable = false;
        }
    }

    public void UpdateProgressBar()
    {
        progressBar.value = progressValue;
    }

    public void showRewardsPage()
    {
        rewardsPage.SetActive(true);
    }
}

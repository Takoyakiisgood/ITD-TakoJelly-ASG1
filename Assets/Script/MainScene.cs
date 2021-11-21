using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour
{
    public GameManager gameManager;

    public Slider progressBar;
    public int progressValue;

    public Button viewMask;
    public Button viewShield;
    public Button viewSanitizer;

    public GameObject rewardsPage;

    void Start()
    {
        progressValue = 0;
        CheckCollectables();
        UpdateProgressBar();
    }

    private void Update()
    {
        
    }

    public void CheckCollectables()
    {
        //if user has mask will set button to be interactable
        if (gameManager.hasMask == true)
        {
            viewMask.interactable = true;
            progressValue++;
        }
        else
        {
            viewMask.interactable = false;
        }

        //if user has Face Shield will set button to be interactable
        if (gameManager.hasShield == true)
        {
            viewShield.interactable = true;
            progressValue++;
        }
        else
        {
            viewShield.interactable = false;
        }

        //if user has Sanitizer will set button to be interactable
        if (gameManager.hasSanitizer == true)
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

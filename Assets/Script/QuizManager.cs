using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class QuizManager : MonoBehaviour
{
    public GameManager gm;

    public ToggleGroup toggleGrp1;
    public ToggleGroup toggleGrp2;
    public ToggleGroup toggleGrp3;

    public Text question1;
    public Text question2;
    public Text question3;

    public Text aLabel1;
    public Text bLabel1;
    public Text cLabel1;

    public Text aLabel2;
    public Text bLabel2;
    public Text cLabel2;

    public Text aLabel3;
    public Text bLabel3;
    public Text cLabel3;

    public int points;

    public GameObject congratsPage;
    public GameObject collectable;
    public Text collectableText;
    public Sprite sanitizer;
    public Sprite mask;
    public Sprite shield;

    public GameObject gameOverPage;

    public GameObject alreadyComplete;

    public GameObject losingAudioPrefab;
    public GameObject victoryAudioPrefab;

    public void displayDiningQns()
    {
        question1.text = "Q1: When should you take of your mask?";
        // correct answer V
        aLabel1.text = "When consuming food and drinks.";
        bLabel1.text = "When talking to your friends while not consuming anything.";
        cLabel1.text = "When ordering your food from the stall.";

        question2.text = "Q2: What do you do after your meal?";
        aLabel2.text = "Leave the table unmasked.";
        bLabel2.text = "Leave your trays and crockery on the table and leave immediately.";
        // correct answer V
        cLabel2.text = "Return your trays and crockery and throw away disposables in the bin.";

        question3.text = "Q3: Where should you sit?";
        aLabel3.text = "Together with 5 other patrons on marked seats.";
        // correct answer V
        bLabel3.text = "On unmarked seats.";
        cLabel3.text = "On marked seats.";
    }

    public void displaySportsQns()
    {
        question1.text = "Q1: Who should you exercise with?";
        aLabel1.text = "Exercise with 5 other friends.";
        bLabel1.text = "Exercise with 5 other family members.";
        // correct answer V
        cLabel1.text = "Exercise alone.";

        question2.text = "Q2: What do you do if you need to drink water?";
        aLabel2.text = "Drink from a public water cooler/fountain.";
        // correct answer V
        bLabel2.text = "Drink from your own water bottle.";
        cLabel2.text = "Drink from your friend's bottle";

        question3.text = "Q3: What do you do after your exercise?";
        // correct answer V
        aLabel3.text = "Put on your mask immediately.";
        bLabel3.text = "Rest on the bench with mask off for the next 30 minutes";
        cLabel3.text = "Walk home without a mask.";
    }

    public void displaySymptomsQns()
    {
        question1.text = "Q1: What are the symptoms of Covid-19?";
        aLabel1.text = "Runny nose, Difficulty breathing, Sore throat, Cough, Fever, Stomachache.";
        // correct answer V
        bLabel1.text = "Difficulty breathing, Fever, Running nose, Sore throat, Cough, Loss of sense of smell.";
        cLabel1.text = "Diarrhea, Difficulty breathing, Sore throat, Cough, Fever, Loss of sense of smell.";

        question2.text = "Q2: What should you do if you have symptoms of Covid-19?";
        // correct answer V
        aLabel2.text = "Visit a Public Health Preparedness Clinic (PHPC) immediately.";
        bLabel2.text = "Continue with your daily activity at work/school.";
        cLabel2.text = "Visit your friend and ask them what to do.";

        question3.text = "Q3: What should you do after a Swab Test?";
        aLabel3.text = "Go to the supermarket to buy your daily necessities.";
        bLabel3.text = "Go and meet your friends.";
        // correct answer V
        cLabel3.text = "Go home via private cab/transport.";
    }

    public void ShowCongratsPage()
    {
        congratsPage.SetActive(true);
        GameObject audioObj = Instantiate(victoryAudioPrefab, transform.position, Quaternion.identity, null);
        Debug.Log("Showing Congrats page");
        if (gm.hasMask == false)
        {
            collectable.GetComponent<Image>().sprite = mask;
            collectableText.text = "You earned a mask!";
            gm.hasMask = true;
        }
        else
        {
            if (gm.hasSanitizer == false)
            {
                collectable.GetComponent<Image>().sprite = sanitizer;
                collectableText.text = "You earned a hand sanitizer!";
                gm.hasSanitizer = true;
            }
            else
            {
                if (gm.hasShield == false)
                {
                    collectable.GetComponent<Image>().sprite = shield;
                    collectableText.text = "You earned a face shield!";
                    gm.hasShield = true;
                }
            }
        }
    }

    public void ShowGameOverPage()
    {
        gameOverPage.SetActive(true);
        GameObject audioObj = Instantiate(losingAudioPrefab, transform.position, Quaternion.identity, null);
    }
    
    public void BackToMainMenu()
    {
        gm.mainScene();
    }

    public void CheckAnswer()
    {
        //dining poster
        if (gm.PosterInt == 3)
        {
            if (toggleGrp1.ActiveToggles().FirstOrDefault() == toggleGrp1.GetComponentsInChildren<Toggle>()[0])
            {
                //correct answer
                Debug.Log("Q1 Correct!");
                points++;
            }
            if (toggleGrp2.ActiveToggles().FirstOrDefault() == toggleGrp2.GetComponentsInChildren<Toggle>()[2])
            {
                //correct answer
                Debug.Log("Q2 Correct!");
                points++;
            }
            if (toggleGrp3.ActiveToggles().FirstOrDefault() == toggleGrp3.GetComponentsInChildren<Toggle>()[1])
            {
                //correct answer
                Debug.Log("Q3 Correct!");
                points++;
            }

            if (points == 3)
            {
                gm.completeDining = true;
                Debug.Log("dining poster completed.");
                ShowCongratsPage();
            }
            else
            {
                ShowGameOverPage();
            }

        }

        //sports poster
        if (gm.PosterInt == 2)
        {
            if (toggleGrp1.ActiveToggles().FirstOrDefault() == toggleGrp1.GetComponentsInChildren<Toggle>()[2])
            {
                //correct answer
                Debug.Log("Q1 Correct!");
                points++;
            }
            if (toggleGrp2.ActiveToggles().FirstOrDefault() == toggleGrp2.GetComponentsInChildren<Toggle>()[1])
            {
                //correct answer
                Debug.Log("Q2 Correct!");
                points++;
            }
            if (toggleGrp3.ActiveToggles().FirstOrDefault() == toggleGrp3.GetComponentsInChildren<Toggle>()[0])
            {
                //correct answer
                Debug.Log("Q3 Correct!");
                points++;
            }
            if (points == 3)
            {
                gm.completeSports = true;
                Debug.Log("sports poster completed.");
                ShowCongratsPage();
            }
            else
            {
                ShowGameOverPage();
            }
        }

        //symptoms poster
        if (gm.PosterInt == 1)
        {
            if (toggleGrp1.ActiveToggles().FirstOrDefault() == toggleGrp1.GetComponentsInChildren<Toggle>()[1])
            {
                //correct answer
                Debug.Log("Q1 Correct!");
                points++;
            }
            if (toggleGrp2.ActiveToggles().FirstOrDefault() == toggleGrp2.GetComponentsInChildren<Toggle>()[0])
            {
                //correct answer
                Debug.Log("Q2 Correct!");
                points++;
            }
            if (toggleGrp3.ActiveToggles().FirstOrDefault() == toggleGrp3.GetComponentsInChildren<Toggle>()[2])
            {
                //correct answer
                Debug.Log("Q3 Correct!");
                points++;
            }
            if (points == 3)
            {
                gm.completeSymptoms = true;
                Debug.Log("symptoms poster completed.");
                ShowCongratsPage();
            }
            else
            {
                ShowGameOverPage();
            }
        }
    }

    public void DisplayQns()
    {
        if (gm.PosterInt == 3)
        {
            if (gm.completeDining == true)
            {
                alreadyComplete.SetActive(true);
            }
            else
            {
                displayDiningQns();
            }   
        }
        if (gm.PosterInt == 2)
        {
            if (gm.completeSports == true)
            {
                alreadyComplete.SetActive(true);
            }
            else
            {
                displaySportsQns();
            }
        }
        if (gm.PosterInt == 1)
        {
            if (gm.completeSymptoms == true)
            {
                alreadyComplete.SetActive(true);
            }
            else
            {
                displaySymptomsQns();
            }
        }
    }

    private void Awake()
    {
        gm = GameManager.instance;
    }

    // Start is called before the first frame update
    void Start()
    {
        DisplayQns();
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

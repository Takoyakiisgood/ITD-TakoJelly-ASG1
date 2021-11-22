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

    public void displayDiningQns()
    {
        question1.text = "When should you take of your mask?";
        // correct answer V
        aLabel1.text = "When consuming food and drinks.";
        bLabel1.text = "When talking to your friends while not consuming anything.";
        cLabel1.text = "When ordering your food from the stall.";

        question2.text = "What do you do after your meal?";
        aLabel2.text = "Leave the table unmasked.";
        bLabel2.text = "Leave your trays and crockery on the table and leave immediately.";
        // correct answer V
        cLabel2.text = "Return your trays and crockery and throw away disposables in the bin.";

        question3.text = "Where should you sit?";
        aLabel3.text = "Together with 5 other patrons on marked seats.";
        // correct answer V
        bLabel3.text = "On unmarked seats.";
        cLabel3.text = "On marked seats.";
    }

    public void displaySportsQns()
    {
        question1.text = "Who should you exercise with?";
        aLabel1.text = "Exercise with 5 other friends.";
        bLabel1.text = "Exercise with 5 other family members.";
        // correct answer V
        cLabel1.text = "Exercise alone.";

        question2.text = "What do you do if you need to drink water?";
        aLabel2.text = "Drink from a public water cooler/fountain.";
        // correct answer V
        bLabel2.text = "Drink from your own water bottle.";
        cLabel2.text = "Drink from your friend's bottle";

        question3.text = "What do you do after your exercise?";
        // correct answer V
        aLabel3.text = "Put on your mask immediately.";
        bLabel3.text = "Rest on the bench with mask off for the next 30 minutes";
        cLabel3.text = "Walk home without a mask.";
    }

    public void displaySymptomsQns()
    {
        question1.text = "What are the symptoms of Covid-19?";
        aLabel1.text = "Runny nose, Difficult7y breathing, Sore throat, Cough, Fever, Stomachache.";
        // correct answer V
        bLabel1.text = "Difficulty breathing, Fever, Running nose, Sore throat, Cough, Loss of sense of smell.";
        cLabel1.text = "Diarrhea, Difficulty breathing, Sore throat, Cough, Fever, Loss of sense of smell.";

        question2.text = "What should you do if you have symptoms of Covid-19?";
        // correct answer V
        aLabel2.text = "Visit a Public Health Preparedness Clinic (PHPC) immediately.";
        bLabel2.text = "Continue with your daily activity at work/school.";
        cLabel2.text = "Visit your friend and ask them what to do.";

        question3.text = "What should you do after a Swab Test?";
        aLabel3.text = "Go to the supermarket to buy your daily necessities.";
        bLabel3.text = "Go and meet your friends.";
        // correct answer V
        cLabel3.text = "Go home via private cab/transport.";
    }

    public void CheckAnswer()
    {
        if (gm.PosterInt == 1)
        {
            if (toggleGrp1.ActiveToggles().FirstOrDefault() == toggleGrp1.GetComponentsInChildren<Toggle>()[0])
            {
                //correct answer
            }
            if (toggleGrp2.ActiveToggles().FirstOrDefault() == toggleGrp2.GetComponentsInChildren<Toggle>()[2])
            {
                //correct answer
            }
            if (toggleGrp3.ActiveToggles().FirstOrDefault() == toggleGrp3.GetComponentsInChildren<Toggle>()[1])
            {
                //correct answer
            }

        }

        if (gm.PosterInt == 2)
        {
            if (toggleGrp1.ActiveToggles().FirstOrDefault() == toggleGrp1.GetComponentsInChildren<Toggle>()[2])
            {
                //correct answer
            }
            if (toggleGrp2.ActiveToggles().FirstOrDefault() == toggleGrp2.GetComponentsInChildren<Toggle>()[1])
            {
                //correct answer
            }
            if (toggleGrp3.ActiveToggles().FirstOrDefault() == toggleGrp3.GetComponentsInChildren<Toggle>()[0])
            {
                //correct answer
            }

        }

        if (gm.PosterInt == 3)
        {
            if (toggleGrp1.ActiveToggles().FirstOrDefault() == toggleGrp1.GetComponentsInChildren<Toggle>()[1])
            {
                //correct answer
            }
            if (toggleGrp2.ActiveToggles().FirstOrDefault() == toggleGrp2.GetComponentsInChildren<Toggle>()[0])
            {
                //correct answer
            }
            if (toggleGrp3.ActiveToggles().FirstOrDefault() == toggleGrp3.GetComponentsInChildren<Toggle>()[2])
            {
                //correct answer
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
        toggleGrp1 = GetComponent<ToggleGroup>();
        toggleGrp2 = GetComponent<ToggleGroup>();
        toggleGrp3 = GetComponent<ToggleGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

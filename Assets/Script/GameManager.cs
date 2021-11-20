using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool maskCollectable;
    private bool faceShieldCollectable;
    private bool handSanitizerCollectble;

    public GameObject maskObj;
    public GameObject faceshieldObj;
    public GameObject handsanitizerObj;

    // Start is called before the first frame update
    void Start()
    {
        SetCollectableUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetCollectableUI()
    {
        if (faceshieldObj != null && handsanitizerObj != null && maskObj != null)
        {
            //set everything to be inactive first
            faceshieldObj.SetActive(false);
            handsanitizerObj.SetActive(false);
            maskObj.SetActive(true);

            //then check if the collectable status are active, if yes then show the UI
            if (maskCollectable)
            {
                maskObj.SetActive(true);
            }
            else if (faceShieldCollectable)
            {
                faceshieldObj.SetActive(true);
            }
            else if (handSanitizerCollectble)
            {
                handsanitizerObj.SetActive(true);
            }
        }
        
    }

    public void SetMaskActive()
    {
        maskCollectable = true;
        handSanitizerCollectble = false;
        faceShieldCollectable = false;
    }

    public void SetHandSanitizerActive()
    {
        handSanitizerCollectble = true;
        maskCollectable = false;
        faceShieldCollectable = false;
    }

    public void SetFaceShieldActive()
    {
        faceShieldCollectable = true;
        handSanitizerCollectble = false;
        maskCollectable = false;
    }

    public void Quit()
    {
        Application.Quit();
    }

    //index 0 is mainScene, 1 is AR Camera, 2 is QuestionScene, 3 is ViewModelScene
    public void mainScene()
    {
        //Load scene
        SceneManager.LoadScene(0);
    }

    public void arCamera()
    {
        //Load scene
        SceneManager.LoadScene(1);
    }

    public void QuestionScene()
    {
        //Load scene
        SceneManager.LoadScene(2);
    }

    public void ViewModelScene()
    {
        SceneManager.LoadScene(3);
    }
}

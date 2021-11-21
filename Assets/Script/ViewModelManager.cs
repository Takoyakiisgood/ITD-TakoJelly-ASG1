using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class ViewModelManager : MonoBehaviour
{
    public GameObject[] MidObjects;
    public ContentPositioningBehaviour content;
    public GameManager gm;

    //get the user touch value;
    private Touch firstTouch;

    public Text titleTxt;

    public GameObject SliderUI;

    private void Awake()
    {
        gm = GameManager.instance;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (MidObjects != null)
        {
            SetStage();
        }

        //set slider UI to be false first
        if (SliderUI != null)
        {
            SliderUI.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        StoreTouches();
    }

    private void StoreTouches()
    {
        //check whether unity has detected touches
        if (Input.touchCount > 0)
        {
            //if more than 0, store touches
            firstTouch = Input.GetTouch(0);

            //create a ray from the touch position
            Ray ray = Camera.main.ScreenPointToRay(firstTouch.position);

            //create a variable to hold the hit information
            RaycastHit info;

            //using the ray variable , check if the ray hits any objects in the scene
            if (Physics.Raycast(ray, out info))
            {
                //if hits an objects, display information
                //debugTxt.text = info.collider.name;
                if (info.collider.name == "Mask" || info.collider.name == "HandSanitizer" || info.collider.name == "FaceShield")
                {
                    SliderUI.SetActive(true);
                }

            }
            else
            {
                //debugTxt.text = "First touch is at " + firstTouch.position + " .And it didn't hit anything ";
            }
        }
        else
        {
            //if not, do nothing
            return;
        }
    }

    public void GoBack()
    {
        gm.mainScene();
    }

    public void SetStage()
    {
        if (gm.StageInt == 0)
        {
            titleTxt.text = "Mask Collectable";
        }
        else if (gm.StageInt == 1)
        {
            titleTxt.text = "Face Shield Collectable";
        }
        else 
        {
            titleTxt.text = "Hand Sanitizer Collectable";
        }
        content.AnchorStage = MidObjects[gm.StageInt].GetComponent<AnchorBehaviour>();
        //debugTxt.text = "StageInt =" + gm.StageInt;
        
    }

    public void ToggleAR()
    {
        //check if vuforia is enabled
        if (VuforiaBehaviour.Instance.enabled)
        {
            //turn off vuforia
            VuforiaBehaviour.Instance.enabled = false;
        }
        //if vuforia is not enabled
        else
        {
            //turn on vuforia
            VuforiaBehaviour.Instance.enabled = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPoster1 : MonoBehaviour
{
    public GameManager gm;
    
    private void Awake()
    {
        gm = GameManager.instance;
    }

    // Start is called before the first frame update
    void Start()
    {
        //set the dinning poster to true
        //gm.diningPoster = true;
        //load to another scene
        //gm.QuestionScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

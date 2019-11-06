using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine.UI;

public class Grab : MonoBehaviour
{
	public GameObject MainMap;
    public Text Release;
	Collider myCollider;
    bool state;

    // Start is called before the first frame update
    void Start()
    {
        myCollider = MainMap.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clicked()
    {
        if(state==false){
            Release.text = "RELEASE";
            state=true;
            myCollider.enabled = true;
            MainMap.GetComponent<ManipulationHandler>().enabled = true;
            MainMap.GetComponent<NearInteractionGrabbable>().enabled = true;
        }
        else if(state==true)
        {
            state = false;
            Release.text = "GRAB ME";
            myCollider.enabled = false;
            MainMap.GetComponent<ManipulationHandler>().enabled = false;
            MainMap.GetComponent<NearInteractionGrabbable>().enabled = false;
        }
    	

    }
}

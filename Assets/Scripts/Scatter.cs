using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scatter : MonoBehaviour
{
	Animator anim1,anim2,anim3,anim4,anim5,anim6,anim7;
    
	public GameObject pro7;
	public GameObject pro8;
	public GameObject pro9;
	public GameObject pro10;
	public GameObject pro11;
	public GameObject pro12;
	public GameObject pro13;
    // public GameObject ScatterBack;
    public static bool state=false;
    public Text Booltext;
    public GameObject table1;
    public GameObject table2;
    public GameObject table3;
    public GameObject table4;
    public GameObject table5;
    public GameObject table6;
    public GameObject table7;
    // Start is called before the first frame update
    void Start()
    {
        anim1 = pro7.GetComponent<Animator>();
        anim2 = pro8.GetComponent<Animator>();
        anim3 = pro9.GetComponent<Animator>();
        anim4 = pro10.GetComponent<Animator>();
        anim5 = pro11.GetComponent<Animator>();
        anim6 = pro12.GetComponent<Animator>();
        anim7 = pro13.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clicked()
    {
        if(state==true)
        {
            state = false;
            // anim1.Play("pro7", -1, 0f);
            // anim2.Play("pro8", -1, 0f);
            // anim3.Play("pro9", -1, 0f);
            // anim4.Play("pro10", -1, 0f);
            // anim5.Play("pro11", -1, 0f);
            // anim6.Play("pro12", -1, 0f);
            // anim7.Play("pro13", -1, 0f);
            anim1.SetTrigger("Inactive");
            anim2.SetTrigger("Inactive");
            anim3.SetTrigger("Inactive");
            anim4.SetTrigger("Inactive");
            anim5.SetTrigger("Inactive");
            anim6.SetTrigger("Inactive");
            anim7.SetTrigger("Inactive");

            Booltext.text = "SCATTER";
            // anim1.SetTrigger("setoff");
            // anim2.SetTrigger("setoff");
            // anim3.SetTrigger("setoff");
            // anim4.SetTrigger("setoff");
            // anim5.SetTrigger("setoff");
            // anim6.SetTrigger("setoff");
            // anim7.SetTrigger("setoff");
            GlobalControl.sendValFunc = "SetOff";
            table1.SetActive(false);
            table2.SetActive(false);
            table3.SetActive(false);
            table4.SetActive(false);
            table5.SetActive(false);
            table6.SetActive(false);
            table7.SetActive(false);
            Debug.LogWarning("Scatter");
        }
        else if(state==false)
        {
            state = true;
            anim1.SetTrigger("Active");
            anim2.SetTrigger("Active");
            anim3.SetTrigger("Active");
            anim4.SetTrigger("Active");
            anim5.SetTrigger("Active");
            anim6.SetTrigger("Active");
            anim7.SetTrigger("Active");

            Booltext.text = "MERGE";
            // anim1.SetTrigger("setoff2");
            // anim2.SetTrigger("setoff2");
            // anim3.SetTrigger("setoff2");
            // anim4.SetTrigger("setoff2");
            // anim5.SetTrigger("setoff2");
            // anim6.SetTrigger("setoff2");
            // anim7.SetTrigger("setoff2");
            // ScatterBack.SetActive(true);
            GlobalControl.sendValFunc = "NoSetOff";
            Debug.LogWarning("Merge");
        }
        
        // pro7.GetComponent<Animation>()["pro7"].wrapMode = WrapMode.Once;
        // // anim1.Play("pro7");
    	

    	// pro7.GetComponent<setOffProvinces>().enabled = false;
    	// pro13.GetComponent<setOffProvinces>().enabled = false;
    }
}

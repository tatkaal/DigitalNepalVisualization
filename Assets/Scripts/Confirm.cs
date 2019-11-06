using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confirm : MonoBehaviour
{

	public GameObject welcomePanel;
    public GameObject loginPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clicked()
    {
    	// showmenu.SetActive(true);
    	welcomePanel.SetActive(false);
        loginPanel.SetActive(true);
    }
}

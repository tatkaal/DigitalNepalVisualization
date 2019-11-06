using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Login : MonoBehaviour
{
    public GameObject showmenu;
	public GameObject loginObject;
	public GameObject showMap;
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
        loginObject.SetActive(false);
        showmenu.SetActive(true);
    	showMap.SetActive(true);
    }
}

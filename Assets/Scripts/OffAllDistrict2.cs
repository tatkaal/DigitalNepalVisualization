using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffAllDistrict2 : MonoBehaviour
{
	public GameObject District1;
	public GameObject District2;
	public GameObject District3;
	public GameObject District4;
	public GameObject District5;
	public GameObject District6;
	public GameObject District7;
	public GameObject District8;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void offAll()
    {
    	District1.SetActive(false);
    	District2.SetActive(false);
    	District3.SetActive(false);
    	District4.SetActive(false);
    	District5.SetActive(false);
    	District6.SetActive(false);
    	District7.SetActive(false);
    	District8.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showMenu : MonoBehaviour
{
    public GameObject window;
    public GameObject grab;
    public GameObject scatter;
    public GameObject graph;
    // public GameObject cling;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = window.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clicked()
    {
        anim.SetTrigger("Active");
    	grab.SetActive(true);
    	scatter.SetActive(true);
        graph.SetActive(true);
        // cling.SetActive(true);
    }
}

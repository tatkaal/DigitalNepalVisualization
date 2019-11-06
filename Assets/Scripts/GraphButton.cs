using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GraphButton : MonoBehaviour
{
    public GameObject infoscene;
    public GameObject NepalMap;
    public GameObject for1;
    public GameObject for2;
    public GameObject for3;
    public GameObject for4;
    public GameObject for5;
    public GameObject for6;
    public GameObject for7;

    public GameObject MenuButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pressed()
    {
        NepalMap.SetActive(false);
        infoscene.SetActive(true);
        for1.SetActive(false);
        for2.SetActive(false);
        for3.SetActive(false);
        for4.SetActive(false);
        for5.SetActive(false);
        for6.SetActive(false);
        for7.SetActive(false);
        MenuButton.SetActive(false);
    	// Scene currentScene = SceneManager.GetActiveScene ();

    	// string sceneName = currentScene.name;

    	// if (sceneName == "Demo_scene") 
     //    {
     //        SceneManager.LoadScene("infoscene");
     //    }

    }
}

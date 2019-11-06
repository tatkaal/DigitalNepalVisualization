using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Province_back : MonoBehaviour
{
	public GameObject province;
	public GameObject nepalMap;
    public GameObject ResetMenuButton;

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
    	province.SetActive(false);
        // UnityEditor.PrefabUtility.ResetToPrefabState(nepalMap);
    	nepalMap.SetActive(true);
        ResetMenuButton.SetActive(true);
        // Instantiate(nepalMap);
        // transform.position = new Vector3(0.57f, 0.9079999f, 5.2f);
    }
}

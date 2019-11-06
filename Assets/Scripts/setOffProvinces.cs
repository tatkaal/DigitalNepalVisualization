using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.SceneManagement;

public class setOffProvinces : MonoBehaviour
{
	public GameObject provinces;
    public int pro_num;
    public GameObject clickedObject;
    private string getVal = "";
    public GameObject table;
    public GameObject checkScatter;
    public GameObject MenuButton;

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
        if(Scatter.state == true)
        {
            getVal = GlobalControl.sendValFunc;
            Debug.LogWarning("This is Global Controller" + getVal);

            // clickedObject = GameObject.Find("province"+pro_num);
            // Debug.LogWarning("province"+pro_num);

            if(getVal == "SetOff")
            {
                provinces.SetActive(false);
                clickedObject.SetActive(true);
            }
            else if(getVal == "NoSetOff")
            {
                table.SetActive(true);
            }

            // prov7.transform.position = new Vector3(-2.0f, 1.0f, 1.0f);
            // prov7.transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime);
            // transform.position = new Vector3(20.0f,10,0);

            // this.transform.Translate (0, 1.0f * Time.deltaTime, 0);
        }
        else
        {
            provinces.SetActive(false);
            MenuButton.SetActive(false);
            // SceneManager.LoadScene("province");
            
            // Destroy(provinces);
            clickedObject.SetActive(true);

        }
       

    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour {

    public GameObject CBhead;
    public GameObject GOstart, GOcredits, GOexit;
    public float _start = 0;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 100, Color.green);

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward) * 100, out hit, 100.0f))
        {
            if(hit.transform.tag == "Start")
            {
                GOstart.transform.GetComponent<TextMesh>().color = Color.magenta;
                _start += Time.deltaTime;
                if(_start > 2)
             {
                    
                    GOstart.transform.GetComponent<TextMesh>().color = Color.green;
                    if(_start > 4)
                    {
                        SceneManager.LoadScene(1);
                    }
                    
             }
               
            }

            if (hit.transform.tag == "Credits")
            {
                GOcredits.transform.GetComponent<TextMesh>().color = Color.magenta;
                _start += Time.deltaTime;
                if (_start > 2)
                {

                    GOcredits.transform.GetComponent<TextMesh>().color = Color.green;
                    if (_start > 4)
                    {
                        print("Start");
                    }

                }

            }

            if (hit.transform.tag == "Exit")
            {
                GOexit.transform.GetComponent<TextMesh>().color = Color.magenta;
                _start += Time.deltaTime;
                if (_start > 2)
                {

                    GOexit.transform.GetComponent<TextMesh>().color = Color.green;
                    if (_start > 4)
                    {
                        Application.Quit();
                    }

                }

            }
        }
        else
        {            
            GOstart.transform.GetComponent<TextMesh>().color = Color.white;
            GOcredits.transform.GetComponent<TextMesh>().color = Color.white;
            GOexit.transform.GetComponent<TextMesh>().color = Color.white;

            _start = 0;
        }


    }
}

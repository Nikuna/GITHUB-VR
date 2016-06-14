using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour {
        
    public GameObject GORetry, GOmainmenu, GOexit, nave;
    public float _start = 0;
    void Start()
    {
        GORetry.SetActive(false);
        GOexit.SetActive(false);
        GOmainmenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(nave.active == false)
        {

            GORetry.SetActive(true);
            GOexit.SetActive(true);
            GOmainmenu.SetActive(true);
        }

        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 100, Color.green);

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward) * 100, out hit, 100.0f))
        {
            if (hit.transform.tag == "Retry")
            {
                GORetry.transform.GetComponent<TextMesh>().color = Color.magenta;
                _start += Time.deltaTime;
                if (_start > 2)
                {

                    GORetry.transform.GetComponent<TextMesh>().color = Color.green;
                    if (_start > 4)
                    {
                        SceneManager.LoadScene(1);
                    }

                }

            }

            if (hit.transform.tag == "MainMenu")
            {
                GOmainmenu.transform.GetComponent<TextMesh>().color = Color.magenta;
                _start += Time.deltaTime;
                if (_start > 2)
                {

                    GOmainmenu.transform.GetComponent<TextMesh>().color = Color.green;
                    if (_start > 4)
                    {
                        SceneManager.LoadScene(0);

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
            GORetry.transform.GetComponent<TextMesh>().color = Color.white;
            GOmainmenu.transform.GetComponent<TextMesh>().color = Color.white;
            GOexit.transform.GetComponent<TextMesh>().color = Color.white;

            _start = 0;
        }


    }
}

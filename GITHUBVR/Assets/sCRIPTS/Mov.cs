using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class Mov : MonoBehaviour {

    public GameObject prefab;
    public GameObject mira;
    public GameObject P_Cannon1, P_Cannon2;
    bool Disparar = true;
    
   
    
    void Update ()
    {

        if (Input.touchCount == 1 && Disparar == true)
        {
            Disparar = false;
            for (int i = 0; i < PoolManager.Instance.bulletList.Count; i++)
            {
                if (PoolManager.Instance.bulletList[i].activeInHierarchy == false)
                {
                    PoolManager.Instance.bulletList[i].SetActive(true);
                    PoolManager.Instance.bulletList[i].transform.position = mira.transform.position;
                    PoolManager.Instance.bulletList[i].transform.rotation = mira.transform.rotation;
                    AudioSource audio = GetComponent<AudioSource>();
                    P_Cannon1.SetActive(true);
                    audio.Play();
                    break;
                }
            }
        }

        if(Input.touchCount == 0)
        {
            Disparar = true;
            P_Cannon1.SetActive(false);

        }

        if (Input.GetMouseButtonDown(0) && Disparar == true)
        {
            P_Cannon1.SetActive(true);
            P_Cannon2.SetActive(true);

            Disparar = false;
            for (int i = 0; i < PoolManager.Instance.bulletList.Count; i++)
            {
                if (PoolManager.Instance.bulletList[i].activeInHierarchy == false)
                {
                    PoolManager.Instance.bulletList[i].SetActive(true);
                    PoolManager.Instance.bulletList[i].transform.position = mira.transform.position;
                    PoolManager.Instance.bulletList[i].transform.rotation = mira.transform.rotation;
                    AudioSource audio = GetComponent<AudioSource>();

                    audio.Play();
                    break;
                }
            }
        } 
        if(Disparar == false)
        {
            Disparar = true;
            //P_Cannon1.SetActive(false);

        }

    }
}

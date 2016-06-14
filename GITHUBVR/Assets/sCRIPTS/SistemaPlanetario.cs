using UnityEngine;
using System.Collections;

public class SistemaPlanetario : MonoBehaviour {

    public GameObject[] Planetas;
    float vel1, vel2;
    void Start()
    {
        
        vel1 = Random.Range(10, 35);
        vel2 = Random.Range(10, 35);
    }
	// Update is called once per frame
	void Update ()
    {
        
        if (Planetas.Length == 0)
        {
            print("No hay planetas");
        }
        else
        {
            Planetas[0].transform.RotateAround(transform.position, new Vector3(0, 1, 0), vel1 * Time.deltaTime);
            Planetas[1].transform.RotateAround(transform.position, new Vector3(0, 1, 0), vel2 * Time.deltaTime);

        }

    }
}

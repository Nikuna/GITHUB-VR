using UnityEngine;
using System.Collections;

public class Mov2 : MonoBehaviour {

	public int velMov = 10;
	
	// Update is called once per frame
	void Update () {

        if (Input.GetAxis("Vertical") > 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * velMov);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            transform.Translate(Vector3.back * Time.deltaTime * velMov);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * velMov);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Translate(Vector3.left * Time.deltaTime * velMov);
        }

    }
}

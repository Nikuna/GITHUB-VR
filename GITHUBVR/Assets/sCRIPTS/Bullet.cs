using UnityEngine;
using System.Collections;


public class Bullet : MonoBehaviour {

    void Update ()
    {
        

        transform.Translate(new Vector3(0,1,0) * 0.5f);
        if(transform.position.z > 30 || transform.position.y > 30 || transform.position.x > 30 || transform.position.z < -30 || transform.position.y < -30 || transform.position.x < -30)
        {
            OnDisable();
        }
	}

    void OnDisable()
    {
        this.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {            
            LifeandScore._score++;
            OnDisable();
            other.gameObject.SetActive(false);
        }
    }
}

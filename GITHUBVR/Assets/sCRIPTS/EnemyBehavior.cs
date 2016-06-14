using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {

    public GameObject Jugador;
    float velE;
    
	
    void Start()
    {
        Jugador = GameObject.FindGameObjectWithTag("Player");
        
    }

	void Update ()
    {
        transform.LookAt(Jugador.transform);
        transform.position = Vector3.MoveTowards(transform.position, Jugador.transform.position, velE * Time.deltaTime);
        print(Enemy.level);

        switch(Enemy.level)
        {
            case 10: velE = 0.5f;
                break;
            case 9:
                velE = 0.75f;
                break;
            case 8:
                velE = 1;
                break;
            case 7:
                velE = 1.25f;
                break;
            case 6:
                velE = 1.5f;
                break;
            case 5:
                velE = 1.75f;
                break;
            case 4:
                velE = 2;
                break;
            case 3:
                velE = 2.25f;
                break;
            case 2:
                velE = 2.5f;
                break;
            case 1:
                velE = 2.75f;
                break;
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            this.gameObject.SetActive(false);           
        }

    }

}

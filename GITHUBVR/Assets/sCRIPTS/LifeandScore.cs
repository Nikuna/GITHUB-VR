using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class LifeandScore : MonoBehaviour {

    public GameObject nave,poolmanager;

    public GameObject Vidas;
    int _vidas = 5;

    public GameObject Score;
    public static int _score = 0;
    float timer = 12;

    public GameObject count, dead;
    public AudioClip hit,explosion;
    AudioSource sounds;

    void Start ()
    {
        Vidas = GameObject.FindGameObjectWithTag("Vida");
        Score = GameObject.FindGameObjectWithTag("Score");
        count = GameObject.FindGameObjectWithTag("Count");
        sounds = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        Vidas.GetComponent<TextMesh>().text = "" + _vidas.ToString();
        Score.GetComponent<TextMesh>().text = "" + _score.ToString();
        count.GetComponent<TextMesh>().text = "" + (int)timer;

        if (timer <= 0)
        {

            count.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            sounds.PlayOneShot(hit, 1.0f);
            _vidas--;

            if(_vidas <= 0)
            {
                StartCoroutine(Dead());
            }
        }
    }

    IEnumerator Dead()
    {

        dead.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        nave.SetActive(false);
        poolmanager.SetActive(false);

    }


}

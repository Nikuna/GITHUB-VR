using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

   public float timer, timerLevel;
    public static int level = 10;
    Vector3 pos;
    //Transform rot;
    void Start()
    {
        timer = 0;
        timerLevel = 0;
        level = 10;
    }
    
	void Update ()
    {
        timer += Time.deltaTime;
        timerLevel += Time.deltaTime;


        if(timer >= level)
        {
            timer = 0;
            for (int i = 0; i < PoolManager.Instance.enemyList.Count; i++)
            {
                float x, y, z;
                x = Random.Range(-30.0f, 30.0f);
                y = Random.Range(5.0f, 30.0f);
                z = Random.Range(-30.0f, 30.0f);
                pos = new Vector3(x, y, z);
              

                if (PoolManager.Instance.enemyList[i].activeInHierarchy == false)
                {
                    PoolManager.Instance.enemyList[i].SetActive(true);
                    PoolManager.Instance.enemyList[i].transform.position = pos;                   
                    print(pos);
                    break;
                }
            }
        }
        if(timerLevel >= 10)
        {
            timerLevel = 0;
            level--;
            if (level == 1)
            {
                print("nivel 1");
                level = 2;
            }
        }
        
        
	}
}

﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PoolManager : MonoBehaviour {

    private static PoolManager _instance;

    public static PoolManager Instance
    {
        get
        {
            if(_instance == null)
            {
                GameObject go = new GameObject("PoolManager");
                go.AddComponent<PoolManager>();
            }
            return _instance;
        }
    }

    public GameObject bulletfab,Enemyfab;
    public GameObject bulletContainer,EnemyContainer;
    public GameObject Mira;
    public int BulletToSpawn = 20, EnemyToSpawn = 5;
    public List<GameObject> enemyList = new List<GameObject>();
    public List<GameObject> bulletList = new List<GameObject>();

    void Awake()
    {
        _instance = this;
    }

    void Start()
    {
        for(int i = 0; i < BulletToSpawn; i++)
        {
            GameObject bullet = Instantiate(bulletfab, Mira.transform.position, Mira.transform.rotation) as GameObject;
            bullet.transform.parent = bulletContainer.transform;
            bullet.SetActive(false);
            bulletList.Add(bullet);
        }

        for(int j = 0; j < EnemyToSpawn; j++)
        {
            GameObject enemy = Instantiate(Enemyfab, Vector3.zero, Quaternion.identity) as GameObject;
            enemy.transform.parent = EnemyContainer.transform;
            enemy.SetActive(false);
            enemyList.Add(enemy);
        }

    }
}

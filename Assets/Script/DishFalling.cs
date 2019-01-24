﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishFalling : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public static float timerFall = 0f;
    public float timeBetweenFall = 2f;
    public float speed = 0f;
    public GameObject dish;

    // Update is called once per frame
    void Update()
    {
        timerFall += Time.deltaTime;
        if(timerFall > timeBetweenFall)
        {
            Fall();
        }
        speed = 2550 / 7 ;
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - speed*Time.deltaTime, 0);
    }

    public Transform parent;
    public static float fallingSpeed = 7f;

    void Fall()
    {
        timerFall = 0f;
        GameObject dishInstance = Instantiate(dish, transform.position, transform.rotation) as GameObject;
        dishInstance.transform.SetParent(parent,false);
        dishInstance.transform.localPosition = new Vector3(Random.Range(-520f, 720f), 2550/2, 0);

        Destroy(dishInstance, fallingSpeed);
    }
}

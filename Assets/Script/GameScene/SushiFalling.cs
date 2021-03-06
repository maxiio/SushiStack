﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SushiFalling : MonoBehaviour
{

    public float timerFall = 0f;
    int range;
    public float sushinum;
    public float speed = 0f;
    public bool falling = false;
    

    // Update is called once per frame
    void Update()
    {

        if (!ItemFalling.whichFall)
        {
            if (!falling)
            {
                if (ItemFalling.sushi < 2)
                {
                    if(ItemFalling.sushi>=sushinum && ItemFalling.sushi < sushinum + 0.3)
                    {
                        Fall();
                        falling = true;
                    }
                }
                else if ((int)ItemFalling.sushi == (int)sushinum)  // ItemFalling 스크립트에서 랜덤으로 나온 숫자와 일치하는 초밥을 떨어뜨림
                {
                    Fall();
                    falling = true;
                }
            }
            //else
            //{
            //    GameObject sushiInstance = Instantiate(this.gameObject, transform) as GameObject;
            //    sushiInstance.GetComponent<SushiFalling>().falling = true;
            //}

        }
        if (falling)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - speed * Time.deltaTime, 0);
            timerFall += Time.deltaTime;
            if (transform.localPosition.y<-(2140-2550/2)/*timerFall > DishFalling.fallingSpeed*/) {
                falling = false;
                transform.localPosition = new Vector3(Random.Range(-520f, 520f), 2550 / 2, 0);
            }
        }
    }

    public void Fall()
    {
        speed = 2140 / DishFalling.fallingSpeed; //2140이었음

        timerFall = 0f;
    }

}

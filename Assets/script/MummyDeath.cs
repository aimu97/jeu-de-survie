﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MummyDeath : MonoBehaviour
{
    public int EnemyHealth = 20;
    public GameObject TheEnemy;
    public int StatusCheck;

    void DamageMummy(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }




    void Update()
    {
        if (EnemyHealth <= 0 && StatusCheck == 0)
        {
            StatusCheck = 2;
            TheEnemy.GetComponent<Animation>().Stop("walk");
            TheEnemy.GetComponent<Animation>().Play("fall");
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInvaders : MonoBehaviour
{
    [SerializeField]
    GameObject invasorA;

    [SerializeField]
    GameObject invasorB;

    [SerializeField]
    GameObject invasorC;

    [SerializeField]
    GameObject[] invasores;

    // GameObject[] invasores; -> array, lista de valores a determinar no editor

    [SerializeField]
    int nInvasores = 7;

    [SerializeField]
    float xMin = -3f;

    [SerializeField]
    float yMin = -0.5f;

    [SerializeField]
    float xInc = 1f;

    [SerializeField]
    float yInc = 0.5f;



    void Awake()
    {

        
        float y = yMin;

        for (int line = 0; line < invasores.Length; line++)
        {

            float x = xMin;

            for (int i = 1; i <= nInvasores; i++)
            {
                GameObject newinvader = Instantiate(invasores [line], transform);
                newinvader.transform.position = new Vector3(x, y, 0f);
                x += xInc;
            }
            y += yInc;
        }


    }
}



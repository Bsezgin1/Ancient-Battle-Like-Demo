using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooptater : MonoBehaviour
{
    [SerializeField] private float cooptatingTime = 2f;
    [SerializeField] private float cooptatingRange = 5f;
    [SerializeField] private float counterToCoop = 0;

    [SerializeField] private AIController bot;
    [SerializeField] private GameObject[] heros;
    void Start()
    {
        heros = GameObject.FindGameObjectsWithTag("Hero");
    }
    void Update()
    {
        if(bot.belongsTo != null) return;
        
        GameObject hero = InCooptateRange();
        
        if (hero != null)
        {
            GetHero(hero);
        }
        else
        {
            counterToCoop = 0;
        }
    }

    private void GetHero(GameObject hero)
    {
        counterToCoop += Time.deltaTime;
        if (counterToCoop >= cooptatingTime)
        {
            bot.belongsTo = hero;
        }
    }

    private GameObject InCooptateRange()
    {
        for (int i = 0; i < heros.Length; i++)
        {
            float distanceToHero = Vector3.Distance(heros[i].transform.position, transform.position);
            if (distanceToHero < cooptatingRange)
            {
                return heros[i];
            }
        }

        return null;
    }

    
}

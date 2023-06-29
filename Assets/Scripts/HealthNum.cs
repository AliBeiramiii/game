using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthNum : MonoBehaviour
{
    [SerializeField]Text textHealth;
    Health health;
     void start()
    {
        health = GetComponentInParent<Health>();
    }
     void Update()
    {
        if (health != null)
        {
            textHealth.text = health.getHealth().ToString();
        }
    }
}


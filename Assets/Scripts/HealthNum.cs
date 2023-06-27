using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthNum : MonoBehaviour
{
    public TextMesh output;
    public void awake()
    {
        output = GetComponent<TextMesh>();
    }
    Health health;
    void Awake()
    {
        health = GetComponent<Health>();
    }   
    public void show()
    {
        output.text = ""+health.getHealth();
    }
}

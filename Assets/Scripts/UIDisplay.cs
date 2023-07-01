using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIDisplay : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] Slider healthSlider;
    [SerializeField] Health playerHealth;


    [Header("Score")]
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI failGameScore;
    Scores scorekeeper;
    private void Awake()
    {
        scorekeeper = FindAnyObjectByType<Scores>();
    }
    void Start()
    {
        healthSlider.maxValue = playerHealth.getHealth();
    }

    
    void Update()
    {
        healthSlider.value = playerHealth.getHealth();
        scoreText.text = scorekeeper.getScore().ToString("000000000"); 
    }
}

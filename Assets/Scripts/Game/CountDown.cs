using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    float currentTime = 0f;
    [SerializeField] Text countDownText;
    
    public void showCountDown(float startingTime)
    {
        for (currentTime = startingTime; currentTime > 0; currentTime-=1*Time.deltaTime )
        {
            countDownText.text = currentTime.ToString("0");
        }

    }


}

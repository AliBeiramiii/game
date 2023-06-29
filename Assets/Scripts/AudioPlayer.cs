using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [Header("Crashing")]
    [SerializeField] AudioClip crashingClip;
    [SerializeField] [Range(0f, 1f)]float crashingVolume=1f;
    [Header("Shooting")]
    [SerializeField] AudioClip shootingClip;
    [SerializeField] [Range(0f,1f)]float shootingVolume = 1f;
    

    public void playShootingClip()
    {
        if(shootingClip != null)
        {
            AudioSource.PlayClipAtPoint(shootingClip, Camera.main.transform.position, shootingVolume);
        }
    }
    public void playCrashingClip()
    {
        if (crashingClip != null)
        {
            AudioSource.PlayClipAtPoint(crashingClip, Camera.main.transform.position, crashingVolume);
        }
    }
}

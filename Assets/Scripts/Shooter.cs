using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] float projectileSpeed=10f;
    [SerializeField] float projectileLifeTime = 2f;
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] float firingRate = 0.2f;
                     float nextFire;
    Coroutine firingcoroitine;
    AudioPlayer audioPlayer;
    InputManager input;

    public bool isFiring;
     void Awake()
    {
        audioPlayer = FindObjectOfType<AudioPlayer>();
        input = GetComponent<InputManager>();
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        fire();
    }
    void fire()
    {
        if (input.fire&&Time.time>nextFire)
        {
            nextFire = Time.time + firingRate;
            GameObject instance = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

            Rigidbody2D rb = instance.GetComponent<Rigidbody2D>();
            if(rb!=null)
            {
            rb.velocity = transform.up * projectileSpeed;
            }
             Destroy(instance, projectileLifeTime);
               audioPlayer.playShootingClip();
        }
    }
  //  {
        //if (input.fire&&firingcoroitine==null)
      ///  {
        //    firingcoroitine = StartCoroutine(fireContinuously());
            
            
      //  }
        //else if(firingcoroitine!=null)
        //{
            
            //StopCoroutine(firingcoroitine);
          //  firingcoroitine = null;
        //}
    //}
    //IEnumerator fireContinuously()
    //{
        //while (true)
        //{
            
            //GameObject instance = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
             
            //Rigidbody2D rb = instance.GetComponent<Rigidbody2D>();
            //if(rb!=null)
            //{
                //rb.velocity = transform.up * projectileSpeed;
            //}
           // Destroy(instance, projectileLifeTime);
         //   audioPlayer.playShootingClip();
       //     yield return new WaitForSeconds(firingRate);
     //   }
   // }
    
}

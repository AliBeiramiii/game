using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] float projectileSpeed=10f;
    [SerializeField] float projectileLifeTime = 2f;
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] float firingRate = 0.2f;
    Coroutine firingcoroitine;
    public bool isFiring;
    void Start()
    {
        
    }

    
    void Update()
    {
        fire();
    }
    void fire()
    {
        if (Input.GetKeyDown("space")&&firingcoroitine==null)
        {
            firingcoroitine = StartCoroutine(fireContinuously());
            
            
        }
        else if(firingcoroitine!=null)
        {
            
            StopCoroutine(firingcoroitine);
            firingcoroitine = null;
        }
    }
    IEnumerator fireContinuously()
    {
        while (true)
        {
            GameObject instance = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            Rigidbody2D rb = instance.GetComponent<Rigidbody2D>();
            if(rb!=null)
            {
                rb.velocity = transform.up * projectileSpeed;
            }
            Destroy(instance, projectileLifeTime);
            yield return new WaitForSeconds(firingRate);
        }
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRatePower : MonoBehaviour
{
    [SerializeField] float newFireRate = 0.05f;
    [SerializeField] float FireRateTimer = 5f;
    [SerializeField] GameObject spirit;
    Collider2D collider2D;
    private void Awake()
    {
        collider2D = GetComponent<Collider2D>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Shooter shooter
                = collision.gameObject.GetComponent<Shooter>();
            if (shooter != null)
            {


                StartCoroutine(PowerUp(shooter));


            }
        }
    }
    public IEnumerator PowerUp(Shooter shooter)
    {
        collider2D.enabled = false;
        spirit.SetActive(false);
        activeFireRate(shooter);
        Debug.Log("ative");
        yield return new WaitForSeconds(FireRateTimer);
        Debug.Log("deative");
        deactiveFireRate(shooter);
        Destroy(gameObject);



    }
    private void activeFireRate(Shooter shooter)
    {
        shooter.setFireRate(-newFireRate);
    }
    private void deactiveFireRate(Shooter shooter)
    {
        shooter.setFireRate(newFireRate);
    }
}

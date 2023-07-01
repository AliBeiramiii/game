using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    [SerializeField] float newSpeed = 8f;
    [SerializeField] float speedUpTimer = 5f;
    float curentTime = 0f;
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
            player p1 = collision.gameObject.GetComponent<player>();
            if (p1 != null)
            {
                
                
                StartCoroutine(PowerUp(p1));
                
                
            }
        }
    }
    public IEnumerator PowerUp(player p1)
    {
        collider2D.enabled = false;
        spirit.SetActive(false);
        activeMoveSpeed(p1);
        Debug.Log("ative");
        yield return new WaitForSeconds(speedUpTimer);
        Debug.Log("deative");
        deactiveMoveSpeed(p1);
        Destroy(gameObject);
        


    }
    private void activeMoveSpeed(player p1)
    {
        p1.addSpeed(newSpeed);
    }
    private void deactiveMoveSpeed(player p1)
    {
        p1.addSpeed(-newSpeed);
    }
}

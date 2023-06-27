using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health;
    [SerializeField] bool isBig;
    [SerializeField] bool isMid;
    [SerializeField] bool isSmall;
    [SerializeField] bool isBullet;
    [SerializeField] bool isPlane;
    [SerializeField] WaveConfigSO nextObstacle;
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("what");
        health--;
        if (health <= 0&& (isSmall||isBullet||isPlane))
        {
            Destroy(gameObject);
        }else if ( health<=0&& isMid)
        {
            Destroy(gameObject);
            GameObject obj1 = Instantiate(nextObstacle.getObstaclePrefab(0), transform.position, Quaternion.identity);
            Rigidbody2D rigidBody = obj1.GetComponent<Rigidbody2D>(); 
            Vector2 throwDirection = new Vector2(-4.8f,8.8f);
            rigidBody.AddForce(throwDirection*10);
            GameObject obj2 = Instantiate(nextObstacle.getObstaclePrefab(0), transform.position, Quaternion.identity);
            Rigidbody2D rigidBody2 = obj2.GetComponent<Rigidbody2D>();
            Vector2 throwDirection2 = new Vector2(4.8f, 8.8f);
            rigidBody2.AddForce(throwDirection2 * 10);
            isMid = false;
            isSmall = true;
        }else if (health <= 0 && isBig)
        {
            Destroy(gameObject);
            GameObject obj1 = Instantiate(nextObstacle.getObstaclePrefab(0), transform.position, Quaternion.identity);
            Rigidbody2D rigidBody = obj1.GetComponent<Rigidbody2D>();
            Vector2 throwDirection = new Vector2(-4.8f, 8.8f);
            rigidBody.AddForce(throwDirection * 10);
            GameObject obj2 = Instantiate(nextObstacle.getObstaclePrefab(0), transform.position, Quaternion.identity);
            Rigidbody2D rigidBody2 = obj2.GetComponent<Rigidbody2D>();
            Vector2 throwDirection2 = new Vector2(4.8f, 8.8f);
            rigidBody2.AddForce(throwDirection2 * 10);
            isBig = false;
            isMid = true;
        }
    }
    public float getHealth()
    {
        return health;
    }
}

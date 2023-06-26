using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health;
    [SerializeField] bool isBig;
    [SerializeField] bool isMid;
    [SerializeField] bool isSmall;
    [SerializeField] WaveConfigSO nextObstacle;
    void OnTriggerEnter2D(Collider2D collision)
    {
        health--;
        if (health <= 0&& isSmall)
        {
            Destroy(gameObject);
        }else if ( health<=0&& isMid)
        {
            Instantiate(nextObstacle.getObstaclePrefab(0), transform.position, Quaternion.identity);
            Instantiate(nextObstacle.getObstaclePrefab(0), transform.position, Quaternion.identity);
            isMid = false;
            isSmall = true;
        }else if (health <= 0 && isBig)
        {
            Instantiate(nextObstacle.getObstaclePrefab(0), transform.position, Quaternion.identity);
            Instantiate(nextObstacle.getObstaclePrefab(0), transform.position, Quaternion.identity);
            isBig = false;
            isMid = true;
        }
    }
}

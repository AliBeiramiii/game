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
    [SerializeField] int score;
    [SerializeField] WaveConfigSO nextObstacle;
    [SerializeField] GameManager gameManager;
    AudioPlayer audioPlayer;
    Scores scoreKeeper;
    void Awake()
    {
        score = (int)health;
        audioPlayer = FindObjectOfType<AudioPlayer>();
        scoreKeeper = FindAnyObjectByType<Scores>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        
        
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Obstacle")
        {
            
            health--;

            if ((collision.gameObject.tag == "Player" || collision.gameObject.tag == "Obstacle")

                && health <= 0 && (isSmall || isBullet || isPlane))
            { 
                audioPlayer.playCrashingClip();
                if (!isPlane&&score>7)
                    scoreKeeper.ModifyScore(score);
                if (isPlane)
                    gameManager.gameOver();
                Destroy(gameObject);
            }
            else if ((collision.gameObject.tag == "Player" || collision.gameObject.tag == "Obstacle")
                 && health <= 0 && isMid)
            {
                
                audioPlayer.playCrashingClip();
                if (!isPlane && score > 7)
                    scoreKeeper.ModifyScore(score);
                Destroy(gameObject);
                GameObject obj1 = Instantiate(nextObstacle.getObstaclePrefab(0), transform.position, Quaternion.identity);
                Rigidbody2D rigidBody = obj1.GetComponent<Rigidbody2D>();
                Vector2 throwDirection = new Vector2(-4.8f, 8.8f);
                rigidBody.AddForce(throwDirection * 10);
                GameObject obj2 = Instantiate(nextObstacle.getObstaclePrefab(0), transform.position, Quaternion.identity);
                Rigidbody2D rigidBody2 = obj2.GetComponent<Rigidbody2D>();
                Vector2 throwDirection2 = new Vector2(4.8f, 8.8f);
                rigidBody2.AddForce(throwDirection2 * 10);
                isMid = false;
                isSmall = true;
            } else if ((collision.gameObject.tag == "Player" || collision.gameObject.tag == "Obstacle")
                 && health <= 0 && isBig)
            {
                
                audioPlayer.playCrashingClip();
                if (!isPlane && score > 7)
                    scoreKeeper.ModifyScore(score);
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
        
    }
   
    public float getHealth()
        {
        return health;
        }
}

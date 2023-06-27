using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] WaveConfigSO currentWave;
    [SerializeField] bool isLooping;
    void Start()
    {
        StartCoroutine(spawnObstacle());
    }
    IEnumerator spawnObstacle()
    {
        while (isLooping)
        {
            yield return new WaitForSeconds(currentWave.getFirstWaiting());
            Vector2 randomPosittion = new Vector2(Random.Range(-2f, 2f), 10);
            GameObject obj=Instantiate(currentWave.getObstaclePrefab(0), randomPosittion, Quaternion.identity);
            Rigidbody2D rigidBody = obj.GetComponent<Rigidbody2D>();
            Vector2 throwDirection = new Vector2(randomPosittion.x, 0);
            rigidBody.AddForce(throwDirection*100);
                yield return new WaitForSeconds(currentWave.getRandomSpawnTime());
            

        }
    }
}

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
                Vector2 randomPosittion = new Vector2(Random.Range(-3f, 3f), 10);
                Instantiate(currentWave.getObstaclePrefab(0), randomPosittion, Quaternion.identity);
                yield return new WaitForSeconds(currentWave.getRandomSpawnTime());
            

        }
    }
}

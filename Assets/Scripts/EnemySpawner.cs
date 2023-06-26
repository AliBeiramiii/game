using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] WaveConfigSO currentWave;
    [SerializeField]GameObject obstacle;
    void Start()
    {
        spawnObstacle();
    }
    IEnumerator spawnObstacle()
    {
        for(int i = 0; i < 4; i++)
        {
            Vector2 randomPosittion = new Vector2(Random.Range(-5.6f, 0.7f), 16);
            Instantiate(currentWave.getObstaclePrefab(0), randomPosittion, Quaternion.identity);
            yield return new WaitForSeconds()
        }

    }
}

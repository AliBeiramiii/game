using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="Wave config",fileName ="new Wave Config")]
public class WaveConfigSO : ScriptableObject
{
    [SerializeField]List<GameObject> obstaclePrefabs;
    [SerializeField] float spawnTime;
    [SerializeField] float spawnTimeVariance;
    [SerializeField] float minSpawnTime;
    [SerializeField] float firstWaiting;
    public int getObstacleCount()
    {
        return obstaclePrefabs.Count;
    }
    public GameObject getObstaclePrefab(int index)
    {
        return obstaclePrefabs[index];
    }
    public float getRandomSpawnTime()
    {
        float randomTime = Random.Range(spawnTime - spawnTimeVariance, spawnTime + spawnTimeVariance);
        return Mathf.Clamp(spawnTime, minSpawnTime, float.MaxValue);
    }
    public float getFirstWaiting()
    {
        return firstWaiting;
    }
}

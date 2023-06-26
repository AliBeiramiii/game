using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="Wave config",fileName ="new Wave Config")]
public class WaveConfigSO : ScriptableObject
{
    [SerializeField]List<GameObject> obstaclePrefabs;
    [SerializeField] float spawnTime;
    [SerializeField] float spawnTimeVariance;
    public int getObstacleCount()
    {
        return obstaclePrefabs.Count;
    }
    public GameObject getObstaclePrefab(int index)
    {
        return obstaclePrefabs[index];
    }
    
}

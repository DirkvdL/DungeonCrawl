using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyObj;
    public int maxEnemy = 3;
    //public Vector3 spawnPosition;
    public float spawndelay = 1.0f;

    public void Start()
    {
        StartCoroutine(EnemyWave());
    }

    private void spawnEnemy()
    {
        GameObject a = Instantiate(enemyObj) as GameObject;
        a.transform.position = transform.position;
    }

    IEnumerator EnemyWave()
    {
        
        for (int i = 0; i < maxEnemy; i++)
        {
            spawnEnemy();
            yield return new WaitForSeconds(spawndelay);
        }
        
    }
}

using UnityEngine;
using UnityEngine.Splines;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; 
    public SplineContainer path; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        GameObject newEnemy = Instantiate(enemyPrefab);
        FollowPath script = newEnemy.GetComponent<FollowPath>();
        if (script != null)
        {
            script.splineContainer = path;
        }
    }
}
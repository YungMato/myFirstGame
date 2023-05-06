using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawner : MonoBehaviour
{
    // Enemy Settings
    public List<GameObject> Enemy;      // List of all Enemies in this level, Drag and Drop in Unity
    public int enemyAmount = 20;        // Amount of Enemies in this level
    public float spawnRate = 5f;        // Spawnrate of the Enemies (in seconds)

    // Level Properties
    public int levelminX = -13;
    public int levelmaxX = 13;
    public int levelminY = -9;
    public int levelmaxY = 9;

    // Private variable
    private float spawnClock = 0;

    private void Start()
    {

    }

    void Update()
    {

        if(spawnClock > spawnRate)
        {
            if (enemyAmount > 0)
            {
                Vector2 randomSpawn = new Vector2(Random.Range(levelminX, levelmaxX), Random.Range(levelminY, levelmaxY));
                int randomEnemy = Random.Range(0, Enemy.Count);
                Instantiate(Enemy[randomEnemy], randomSpawn, Quaternion.identity);
                enemyAmount--;
                spawnClock = 0;
            }
        }
        

        spawnClock += Time.deltaTime;
    }
}

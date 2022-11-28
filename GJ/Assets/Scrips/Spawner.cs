using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] Transform[] spawnPoint;

    [SerializeField] GameObject enemy;
    [SerializeField] GameObject enemy2;
    [SerializeField] GameObject enemy3;
    [SerializeField] GameObject Boss;
    public bool boosSpawn= false;
    public bool boos = false;
    GameManager gameManager;
    [SerializeField] float delay;
    int timeOfDelay = 0;
    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {

        if (timeOfDelay >= delay)
        {
            int randSpawnPoint = Random.Range(0, spawnPoint.Length);
            if (boosSpawn)
            {
                Instantiate(Boss, spawnPoint[4].position, transform.rotation);
                boosSpawn = false;
                boos = true;
            }
            else if (!boos)
            {
                Instantiate(enemy, spawnPoint[randSpawnPoint].position, transform.rotation);
               
                Instantiate(enemy3, spawnPoint[2].position, transform.rotation);
                timeOfDelay = 0;
            }
          
        }
        else
        {
            timeOfDelay += 1;
        }
    }

}

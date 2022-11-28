using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int NbEnemyDead = 30;
    Spawner spawner;
    [SerializeField] GameObject menuVictory;
    // Start is called before the first frame update
    void Start()
    {
        spawner = FindObjectOfType<Spawner>();
        
    }

    // Update is called once per frame
    void Update()
    {

        print(NbEnemyDead);
       if (NbEnemyDead <= 0  && spawner.boos == false)
        {
            spawner.boosSpawn = true;   
        }
    }

    public void Loose()
    {
        menuVictory.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;
public class EnemiScore : MonoBehaviour
{
    public Text Dead;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
     gameManager = FindObjectOfType<GameManager>();   
    }

    // Update is called once per frame
    void Update()
    {
        Dead.text = "Enemy  restant : " + gameManager.NbEnemyDead;
    }
}

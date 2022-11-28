using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    GameManager gameManager;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }



    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        pos.y -= speed * Time.fixedDeltaTime;

        if (pos.y < -7)
        {
            Destroy(gameObject);
        }
        transform.position = pos;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            gameManager.NbEnemyDead = gameManager.NbEnemyDead - 1; 
            Destroy(gameObject);
            Destroy(collision.gameObject);


        }
    }
}

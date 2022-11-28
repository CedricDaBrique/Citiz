using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShoot : MonoBehaviour
{
    MeshRenderer meshRenderer;
    [SerializeField] int life = 20;
    



    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
       
    }

    private void Update()
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {

            Destroy(collision.gameObject);
            life--;
            meshRenderer.material.color = Color.red;
            if (life <= 0)
            {
                Destroy(gameObject);

                FindObjectOfType<GameManager>().Loose();
            }


        }

    }
    private void OnCollisionExit(Collision collision)
    {
        meshRenderer.material.color = Color.white;
    }
}

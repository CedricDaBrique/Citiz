using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class Bulletboss : MonoBehaviour
{

    [SerializeField] GameObject bulletPrefab;
    public float speed;
    private float LastSpawn;


    private void Start()
    {

        Shoot();
      
    }
    private void Update()
    {

    }

    private void Shoot()
    {

        GameObject bulletPrefabClone = Instantiate(bulletPrefab, new Vector3(Random.Range(-3,0.3f), transform.position.y, transform.position.z), Quaternion.identity);
        bulletPrefabClone.GetComponent<Bullet>().direction = true;

        Invoke("Shoot", speed);

    }

}
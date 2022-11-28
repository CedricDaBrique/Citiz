using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public bool direction = false;
    public float speed;
    private void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector2(0, direction == true ? -1*3 : 60);
        Destroy(gameObject, 4f);
    }
    private void Update()
    {
       
    }
    private void FixedUpdate()
    {
        Vector3 pos = transform.position;

        if (pos.y > 10)
        {
            Destroy(gameObject);
        }
       
    }
}

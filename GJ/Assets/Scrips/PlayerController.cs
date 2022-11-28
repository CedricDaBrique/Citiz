using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] FixedJoystick joystick;

    Vector3 moveDirection;
    float moveSpeed = 0;
    [SerializeField] float speedMax = 10f;
    [SerializeField] float acceleration = 0.1f;
    [SerializeField] float decceleration = 0.1f;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject menuGameOver;

    //cache

    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Shoot", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        //Vecteur de direction

        if (joystick.Direction.magnitude > 0)
        {
            moveDirection = new Vector3(joystick.Direction.x, joystick.Direction.y, 0).normalized;
            moveSpeed = Mathf.Lerp(moveSpeed, speedMax, acceleration) * joystick.Direction.magnitude;
        }

        else
        {
            moveSpeed = Mathf.Lerp(moveSpeed, 0, decceleration);
        }
       

    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, new Vector3(transform.position.x, transform.position.y+2, transform.position.z), Quaternion.identity);
        bulletPrefab.GetComponent<Bullet>().direction = false;
        Invoke("Shoot", 0.5f);
    }

    private void FixedUpdate()
    {
        //velocité=directionvitesseinclinaison du baton de joie
        rb.velocity = moveDirection * moveSpeed;

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("BulletEnemy"))
        {

            Destroy(gameObject);
            Destroy(collision.gameObject);


            menuGameOver.SetActive(true);

        }
    }

}
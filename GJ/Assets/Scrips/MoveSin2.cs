using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSin2 : MonoBehaviour
{
    float sinCenterX;
    public float amplitude = 2;
    public float frequency = 0.5f;
    public bool inverted = false;
    [SerializeField] float speed = 1;
    private float time = 0;

    // Start is called before the first frame update
    void Start()
    {

        sinCenterX = transform.localPosition.x;
    }



    private void Update()
    {
        time += Time.deltaTime * speed;



        Vector2 pos = transform.position;

        float sin = Mathf.Cos(time) * amplitude;
        if (inverted)
        {
            sinCenterX *= -1;
        }
        pos.x = sinCenterX + sin;
        transform.position = pos;

    }
}

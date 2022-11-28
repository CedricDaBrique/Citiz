using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSin : MonoBehaviour
{
    float sinCenterX;
    public float amplitude = 2 ;
    public float frequency = 0.5f;
    public bool inverted = false;

    // Start is called before the first frame update
    void Start()
    {
        
        sinCenterX = transform.localScale.x -3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        float sin =  Mathf.Sin(pos.y * frequency) * amplitude;
        if (inverted)
        {
            sinCenterX *= -1;
        }

        pos.x = sinCenterX + sin;
        transform.position = pos;
    }
}

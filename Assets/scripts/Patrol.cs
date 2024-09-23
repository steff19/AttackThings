using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float minX;
    public float minY;
    public float maxX;
    public float maxY;

    public static float speed = 2;

    Vector2 targetPos;
    // Start is called before the first frame update
    void Start()
    {
        targetPos = getRanPos();
       
    }

    // Update is called once per frame
    void Update()
    {
        if((Vector2)transform.position != targetPos)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime );
        }
        else
        {
            targetPos = getRanPos();
        }
       // Debug.Log(speed);
    }

    Vector2 getRanPos(){

        float ranY = Random.Range(minY,maxY);
        float ranX = Random.Range(minX,maxX);
        return new Vector2(ranX,ranY);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SplatManager : MonoBehaviour
{
    public float minX;
    public float minY;
    public float maxX;
    public float maxY;
    public GameObject blood;
    public GameObject enemy;
    public bool hit = false;
    Collider2D col;
    public int attempts =0;
    public int attemptsAllowed = 10;
    public GameObject canvas;

	// Use this for initialization
	void Start () {
		col = GetComponent<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {

//detects touch
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended )
        {
            
           // Debug.Log("something happened");
           Touch touch = Input.GetTouch(0);
           Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
           Collider2D touchedCollider  = Physics2D.OverlapPoint(touchPos);

           if( col == touchedCollider){
               
               Instantiate(blood, transform.position, Quaternion.AngleAxis(180, Vector3.up));
               Instantiate(enemy, getRanPos(), Quaternion.identity);
               Count.killed_enemies++;
               Patrol.speed++;
               DestroyImmediate(gameObject,true);
              
             
           }
         
            else{
                 if ( Input.GetTouch(0).phase == TouchPhase.Ended )
                {
               attempts +=1;
              // Debug.Log(attempts);

            } 
            }
             
             
            
           //ends games
            if (attempts == attemptsAllowed){

               // Debug.Log("game over");
                  PlayerPrefs.SetString("score", Count.killDisplay);
                  Patrol.speed = 2f;
                 SceneManager.LoadScene(2);
                }

        }

	}
    Vector2 getRanPos(){

        float ranY = Random.Range(minY,maxY);
        float ranX = Random.Range(minX,maxX);
        return new Vector2(ranX,ranY);

    }
   
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DuckScript : MonoBehaviour
{   
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    private LogicScript logic;
    // Start is called before the first frame update
    public bool DuckAlive = true;


    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && DuckAlive == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
       
    }
    private void OnCollisionEnter2D(Collision2D other) {
        logic.gameOver();
        DuckAlive = false;
    }
}

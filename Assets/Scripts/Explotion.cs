using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explotion : MonoBehaviour {
    public float growSpeed;
    private float maxSize;


	// Use this for initialization
	void Start () {
        maxSize = Random.Range(.5f, .9f); ;
	}

    private void FixedUpdate()
    {
        Grow();
    }


    private void Grow()
    {
 
            transform.localScale += new Vector3(growSpeed, growSpeed, growSpeed);


            if ( transform.localScale.magnitude >= new Vector3(maxSize,maxSize,maxSize).magnitude)
            {
                Destroy(gameObject); 
            }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Asteroid")
        {
            Destroy(collision.gameObject);
        }
    }

}

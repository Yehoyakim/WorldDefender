using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {
    private float speed;

	// Use this for initialization
	void Start () {
        speed = Random.Range(0.03f, 0.08f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Move();
	}

    private void Move()
    {
        transform.Translate(Vector3.up * speed);
        Vector2 direction = Vector3.zero - transform.position;
        transform.up = direction;
    }


}

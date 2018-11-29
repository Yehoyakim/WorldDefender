using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour {
    public Vector3 targetPostion;
    public float speed;
    public GameObject explotion;

	// Update is called once per frame
	void FixedUpdate () {
        Move();
        Explode();
	}

    private void Move()
    {
        transform.Translate(Vector3.up * speed);
        Vector2 direction = targetPostion - transform.position;
        transform.up = direction;
    }

    private void Explode()
    {
        if (Vector2.Distance(transform.position, targetPostion) <= .1f)
        {
            Instantiate(explotion,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
    }
}

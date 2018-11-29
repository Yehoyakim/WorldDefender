using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public GameObject Missile;

	// Update is called once per frame
	void Update () {

        Shoot();
	}

    private void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject spawnedMissile = Instantiate(Missile, transform.position, Quaternion.identity);
            spawnedMissile.GetComponent<Missile>().targetPostion = mousePos;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Asteroid")
        {
            Debug.Log("You Lose");
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject asteroid;


    // Use this for initialization
    void Start()
    {
        StartCoroutine(spawn());
    }

    private IEnumerator spawn()
    {
        while (true) { 
        yield return new WaitForSeconds(1f);
        Vector2 spawnPos = Vector3.zero;

        switch (Random.Range(1, 5))
        {
            case (1):
                spawnPos = Camera.main.ScreenToWorldPoint(new Vector2(Random.Range(0, Screen.width + 1), Screen.height));
                break;
            case (2):
                spawnPos = Camera.main.ScreenToWorldPoint(new Vector2(Random.Range(0, Screen.width + 1), 0));
                break;
            case (3):
                spawnPos = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Random.Range(0, Screen.height + 1)));
                break;
            case (4):
                spawnPos = Camera.main.ScreenToWorldPoint(new Vector2(0, Random.Range(0, Screen.height + 1)));
                break;
        }


        Instantiate(asteroid, spawnPos, Quaternion.identity);
        }
    }
}

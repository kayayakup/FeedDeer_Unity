using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float time;
    private bool canSpawn;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sendDogs();
    }

    void sendDogs()
    {
        // On spacebar press, send dog
        time += Time.deltaTime;
        if (time >= 2)
        {
            canSpawn = true;
        }
        else
        {
            canSpawn = false;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (canSpawn == true)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                time=0;
            }
        }
    }
}

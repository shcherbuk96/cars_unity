using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    private int countDestroyCars = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Enemy Cars")
        {
            Destroy(collision.gameObject);
            countDestroyCars++;

            if (countDestroyCars >= 3&& countDestroyCars<=5)
            {
                trackMove.speed = 0.55f;
                enemyCarsControl.speed = 6f;
                enemyRespawnCars.deltaTimer = 1.8f;
            }
            else if (countDestroyCars >= 6 && countDestroyCars <= 10)
            {
                trackMove.speed = 0.60f;
                enemyCarsControl.speed = 7f;
                enemyRespawnCars.deltaTimer = 1.6f;
            }
            else if (countDestroyCars >= 11 && countDestroyCars <= 15)
            {
                trackMove.speed = 0.65f;
                enemyCarsControl.speed = 8f;
                enemyRespawnCars.deltaTimer = 1.4f;
            }
            else if (countDestroyCars >= 16 && countDestroyCars <= 20)
            {
                trackMove.speed = 0.70f;
                enemyCarsControl.speed = 9f;
                enemyRespawnCars.deltaTimer = 1.3f;
            }

        }
    }
}

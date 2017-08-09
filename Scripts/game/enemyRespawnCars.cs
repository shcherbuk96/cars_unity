using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRespawnCars : MonoBehaviour {
    public GameObject[] cars;
    int carCount;
    private float maxPos=2.6f;
    private float minPos = -2.6f;
    public static float deltaTimer = 2f; //Время,через которое будут появляться enemyCars
    private float timer;
	// Use this for initialization
	void Start () {
        timer = deltaTimer;

	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            carCount = Random.Range(0, 3);
            Vector3 carPos = new Vector3(Random.Range(minPos, maxPos), transform.position.y, transform.position.z); //Рандомная позиция enemyCars
            Instantiate(cars[carCount], carPos, transform.rotation); //Ставим МАШИНУ в ПОЗИЦИЮ
            timer = deltaTimer; //Обнуляем таймер
        }

    }
}

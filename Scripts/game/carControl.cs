using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carControl : MonoBehaviour {
    public float carSpeed=10f;
    private Vector3 position;
	// Use this for initialization
	void Start () {
        position = transform.position;  
	}
	
	// Update is called once per frame
	void Update () {
        position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;  //Управление машины (право, лево)
        position.x = Mathf.Clamp(position.x, -2.6f, 2.6f);   //Ограничение машины по оси Ox
        transform.position = position;
    }

    void OnCollisionEnter2D(Collision2D collision) //Метода столкновения двух тел
    {
        if(collision.gameObject.tag=="Enemy Cars") //Если произошло столкновение с объектом Enemy Cars,то выполняется удаление данного объекта
        {
            Destroy(gameObject);
            uiManager.gameover = false;
            Application.LoadLevel("menu");
        }  
    }
}

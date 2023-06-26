using UnityEngine;
using System.Collections;

public class Movimiento_Boss : MonoBehaviour {
    private Vector2 derecha;
    private Vector2 izquierda;
    private bool direccion = false;


    // Use this for initialization
    void Start() {
        derecha = new Vector2(10, 0);
        izquierda = new Vector2(-10, 0);
    }

    // Update is called once per frame
    void Update() {
        if (transform.position.x <= 10.0f && direccion == true) transform.Translate(derecha * Time.deltaTime);
        if (transform.position.x >= 10.0f) direccion = false;

        if(transform.position.x >= -10.0f && direccion == false) transform.Translate(izquierda * Time.deltaTime);
        if (transform.position.x <= -10.0f) direccion = true;
    }
}

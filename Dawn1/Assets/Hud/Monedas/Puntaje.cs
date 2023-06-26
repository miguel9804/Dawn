using UnityEngine;
using System.Collections;

public class Puntaje : MonoBehaviour {
    public PlayerController heroe;
    public GameObject centenas, decenas, unidades;
    private Animator ce, de, un;
    private string[] contador = { "Contador_0", "Contador_1", "Contador_2", "Contador_3", "Contador_4", "Contador_5", "Contador_6", "Contador_7", "Contador_8", "Contador_9" };

	// Use this for initialization
	void Start () {
        ce = centenas.GetComponent<Animator>();
        de = decenas.GetComponent<Animator>();
        un = unidades.GetComponent<Animator>();

        
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        ActualizadorContador(heroe.Puntos);
	}
    public void ActualizadorContador(int numero)
    {
        int unidades = numero % 10;
        int decenas = numero % 100 - unidades;
        int centenas = numero % 1000 - decenas;
        Debug.Log("numero " + numero + " centenas " + centenas / 100 + " decenas " + decenas / 10 + " unidades " + unidades);

        decenas = decenas / 10;
        centenas = centenas / 100;

        if(numero>9)
        {
            de.Play(contador[decenas]);
        }
        else
        {
            de.Play(contador[0]);
        }

        if(numero>99)
        {
            ce.Play(contador[centenas]);
        }
        else
        {
            ce.Play(contador[0]);
        }
        un.Play(contador[unidades]);

    }

}

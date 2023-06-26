using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {
    private Animator anim;
    private int vidas_boss = 3;
    public const string DISPARO_HEROE = "Disparo_Heroe";
    public Disparo_Boss D_Disparo;
    public Movimiento mov;
    


    public int Vidas_boss
    {
        get
        {
            return vidas_boss;
        }

        set
        {
            vidas_boss = value;
        }
    }

    // Use this for initialization
    void Start () {
        mov = GameObject.Find("Boss_Corriendo_2").GetComponent<Movimiento>();
        D_Disparo = GameObject.Find("Salida_Bala").GetComponent<Disparo_Boss>();
        anim = GetComponent<Animator>();
        anim.SetInteger("Estado_Boss", 1);
       


    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.transform.tag.Equals(DISPARO_HEROE))
            vidas_boss--;
        mov.enabled = false;
        {
            if(vidas_boss==2)
            {

               anim.SetInteger("Estado_Boss", 2);

         D_Disparo.enabled = false;
                mov.enabled = true;




            }
            if (vidas_boss == 1)
            {
                anim.SetInteger("Estado_Boss", 1);
                D_Disparo.enabled = true;
                mov.enabled = false;
            }

            if (vidas_boss==0)
            {
                anim.Play("Muerte");
                D_Disparo.enabled = false;
            }
           
        }
    }

 

    // Update is called once per frame
    void Update () {
        
        
	
	}
}

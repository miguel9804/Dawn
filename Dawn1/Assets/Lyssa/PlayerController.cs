using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour {

  
    public float altura_salto;
    public float velocidad_movimiento;
    public AudioClip pelea;
    AudioSource fuenteAudio;
    private Rigidbody2D rb;
    private Animator anim;
    private bool toco_piso;
    public LayerMask capa_piso;
    public float radio_validacion;
    public Transform validador_piso;
    private Vector2 pos_o;
    public const string VIDA = "Vida";
    public const string MONEDA = "Moneda";
    public const string MUERTEPI = "Muerte_Pinchos";
    public const string MUERTEAC = "Muerte_Acido";
    public const string MUERTEFU = "Muerte_Fuego";
    public const string MUERTEPI2 = "Muerte_Pinchos2";
    public const string MUERTEAC2 = "Muerte_Acido2";
    public const string MUERTEFU2 = "Muerte_Fuego2";
    public const string TRANSFORMACION = "Transformacion";
    public const string DISPARO_BOSS = "Disparo_Boss";
    private int vidas = 3;
    private int puntos = 0;
  


    public int Vidas
    {
        get
        {
            return vidas;
        }

        set
        {
            vidas = value;
        }
    }

    public int Puntos
    {
        get
        {
            return puntos;
        }

        set
        {
            puntos = value;
        }
    }


    
    // Use this for initialization
    void Start ()
    {
        fuenteAudio = GetComponent<AudioSource>();
        pos_o = this.transform.position;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        anim.SetInteger("Estado", 0);
        
        
    }
    
    void OnTriggerEnter2D(Collider2D collider)
    {
       
        if (collider.tag.Equals(TRANSFORMACION))
        {

            anim.Play("Transformacion");
            collider.gameObject.SetActive(false);
            


        }
        if (collider.tag.Equals(MONEDA))
        {
            collider.gameObject.SetActive(false);
            puntos++;
        }
        if(collider.tag.Equals(VIDA))
        {
            
            if (++vidas > 0)
            {
                anim.SetInteger("Vidas", 3);
                anim.SetInteger("Vidas", 2);
                collider.gameObject.SetActive(false);
            }
           if(vidas>3)
            {
                vidas = 3;
                collider.gameObject.SetActive(true);
            }

        }
        if(collider.tag.Equals("Activar_Barra"))
        {
            fuenteAudio.Stop();
            fuenteAudio.clip = pelea;
            fuenteAudio.Play();
        }
      
       
    }
    
    void FixedUpdate()
    {
        toco_piso = Physics2D.OverlapCircle(validador_piso.position, radio_validacion, capa_piso);
    }

	// Update is called once per frame
	void Update () {
        
      
        if (toco_piso) 
        {
            anim.SetInteger("Estado", 0);
            anim.SetInteger("Transformacion", 1);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(velocidad_movimiento, rb.velocity.y);
            rb.transform.localScale = new Vector2(1, 1);
            anim.SetInteger("Estado", 1);
            anim.SetInteger("Transformacion", 2);
        }
        if (Input.GetKey(KeyCode.LeftArrow) )
        {
            rb.velocity = new Vector2(-velocidad_movimiento, rb.velocity.y);
            rb.transform.localScale = new Vector2(-1,1);
            anim.SetInteger("Estado", 1);
            anim.SetInteger("Transformacion", 2);
        }
        if (Input.GetKey(KeyCode.Space) && toco_piso)
        {
            rb.velocity = new Vector2(rb.velocity.x, altura_salto);
            anim.SetInteger("Estado", 2);
            anim.SetInteger("Transformacion", 3);

        }
        if(Input.GetKeyDown(KeyCode.C))
        {
            anim.SetInteger("Transformacion", 4);
        }


        }
    void OnCollisionEnter2D(Collision2D collider)
    {

        Debug.Log(collider.transform.tag);


        if (collider.transform.tag.Equals(MUERTEPI))
        {


            if (--vidas > 0)
            {
                 this.transform.position=pos_o;
            }
            else
            {
                anim.Play("Muerte_por_pinchos");
              
                    
                

            }
        }
        if (collider.transform.tag.Equals(MUERTEFU))
        {


            if (--vidas > 0)
            {
                this.transform.position = pos_o;
            }
            else
            {
                anim.Play("Muerte_por_fuego");
              

            }
        }
        if (collider.transform.tag.Equals(MUERTEAC))
        {


            if (--vidas > 0)
            {
                this.transform.position = pos_o;
            }
            else
            {
                anim.Play("Muerte_por_acido");
               

            }
        }
        if (collider.transform.tag.Equals(MUERTEPI2))
        {


            if (--vidas > 0)
            {
                this.transform.position = pos_o;
            }
            else
            {

                anim.Play("Trans_Muerte_Pinchos");
                
            }
        }
        if (collider.transform.tag.Equals(MUERTEFU2))
        {


            if (--vidas > 0)
            {
                this.transform.position = pos_o;
            }
            else
            {

                anim.Play("Trans_Muerte_Fuego");
               
            }
        }
        if (collider.transform.tag.Equals(MUERTEAC2))
        {


            if (--vidas > 0)
            {
                this.transform.position = pos_o;
            }
            else
            {

                anim.Play("Trans_Muerte_Acido");
              
            }
        }
        if (collider.transform.tag.Equals(DISPARO_BOSS))
        {

            if (--vidas 
> 0)
            {
                this.transform.position = pos_o;
            }
            else
            {

                anim.Play("Trans_Muerte_Pinchos");
               
            }
        }
    }
     

    
}


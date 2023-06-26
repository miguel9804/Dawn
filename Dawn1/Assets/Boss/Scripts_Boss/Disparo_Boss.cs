using UnityEngine;
using System.Collections;

public class Disparo_Boss : MonoBehaviour {
    public GameObject b_disparo;
    public float disparoLife;
    public float speed;
    public static float seg;
	// Use this for initialization
	void Start () {
        Disparo_Boss.seg = 25;
	}
	
	// Update is called once per frame
	void Update () {
        seg += 1 + Time.deltaTime;
        if(Disparo_Boss.seg>25f)
        {
            Disparo_Boss.seg = 0;
            GameObject newdisparo = Instantiate(b_disparo, transform.position, transform.rotation) as GameObject;
            newdisparo.GetComponent<Rigidbody2D>().velocity = transform.right * -speed;
            Destroy(newdisparo.gameObject, disparoLife);

        }
        
        
    }
}

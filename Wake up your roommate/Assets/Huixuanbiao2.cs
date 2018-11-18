using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huixuanbiao2 : MonoBehaviour {

    //public GameObject HXBbiu;
    GameObject camera;
    //public GameObject You;
    //public GameObject roommate;
    //Transform Youtrans;
    //Rigidbody2D HXBrig;
    //ransform roomtrans;

	// Use this for initialization
	void Start () {
        //HXBbiu.SetActive(false);
        //Youtrans = You.GetComponent<Transform>();
        //HXBrig = GetComponent<Rigidbody2D>();
        //roomtrans = roommate.GetComponent<Transform>();
        camera = GameObject.Find("Main Camera");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("1"))
            SETA();
        gameObject.transform.Rotate(new Vector3(0, 0, 5));
        /*if (Input.GetKeyDown("1"))
        {
            HXBbiu.transform.localScale = Youtrans.localScale;
            //gameObject.SetActive(true);
            SETA();
            Vector2 dir = roomtrans.position - gameObject.transform.position;
            float a;
            a = 1 / dir.magnitude;
                HXBrig.velocity = dir * a;
        }*/
        Debug.Log(camera.GetComponent<Camera>().WorldToScreenPoint(gameObject.transform.position));
    }
    void SETA()
    {
        //HXBbiu.SetActive(true);
    }
}

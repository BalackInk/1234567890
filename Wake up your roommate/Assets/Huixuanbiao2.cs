using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huixuanbiao2 : MonoBehaviour {

GameObject ccamera;
    public GameObject You;
    public GameObject roommate;
    Vector3 dir;
   	void Start () {
        
        ccamera = GameObject.Find("Main Camera");
        Vector3 chushi;
        dir = roommate.transform.position - transform.position; 
        GetComponent<Rigidbody2D>().velocity = dir ;
    }
	
	// Update is called once per frame
	void Update () {
       
           
        gameObject.transform.Rotate(new Vector3(0, 0, 5));
                

        


        
        //Debug.Log(ccamera.GetComponent<Camera>().WorldToScreenPoint(gameObject.transform.position));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "roommate")
        {
            Debug.Log(1111);
            GetComponent<Rigidbody2D>().velocity = -dir;
            Debug.Log(GetComponent<Rigidbody2D>().velocity);
        }
    }
}

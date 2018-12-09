using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huixuanbiao2 : MonoBehaviour {

GameObject ccamera;
    public GameObject You;
    public GameObject roommate;
    Vector2 dir = new Vector2(0,0);
    bool backbool = false;

    GameObject textUI;

   	void Start () {
        
        ccamera = GameObject.Find("Main Camera");
        You = GameObject.Find("you");
        textUI = GameObject.Find("Text");
        roommate = GameObject.Find("roommate");
        dir = roommate.transform.position - You.transform.position; 
        GetComponent<Rigidbody2D>().velocity = dir.normalized*10 ;
    }
	
	// Update is called once per frame
	void Update () {
       
           
        gameObject.transform.Rotate(new Vector3(0, 0, 10));


        textUI.transform.position=ccamera.GetComponent<Camera>().WorldToScreenPoint(gameObject.transform.position+Vector3.up);



        //Debug.Log(ccamera.GetComponent<Camera>().WorldToScreenPoint(gameObject.transform.position));
        //↑所以这到底是什么【以及直接让它10秒后destroy是不是更方便 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "roommate")
        {
            GetComponent<Rigidbody2D>().velocity = -dir.normalized*8;
            backbool = true;
        }
        if (backbool && collision.name == "you")
        {
            collision.GetComponent<You>().HPchange(-100);

        }
    }
}

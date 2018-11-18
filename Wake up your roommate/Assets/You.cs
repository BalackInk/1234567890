using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;

public class You : MonoBehaviour {

    public GameObject youObj;
    public GameObject HXB;
    public GameObject[] tools;
    public Sprite[] toolsI;
    public GameObject[] toolsUI;
    int HP = 100;
    Rigidbody2D youRig;
    public bool[] haveTools;
    bool HXB1=false, JJJ2 = false, Water3 = false, Needle4 = false, Hammer5 = false;
    

    // Use this for initialization
    void Start() {

        youRig = youObj.GetComponent<Rigidbody2D>();
        haveTools = new bool[tools.Length];
        Debug.Log(tools.Length);
        for (int i = 0; i < tools.Length; i++)
        {
            haveTools[i] = false;
        }

    }

    // Update is called once per frame
    void Update() {

        float Hor, Vert;
        Hor = Input.GetAxis("Horizontal");
        Vert = Input.GetAxis("Vertical");
        youRig.velocity = new Vector2(Hor, Vert) * 5;

        if (Input.GetKeyDown("1")) 
        {
            GameObject.Instantiate(HXB, gameObject.transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown("2"))
        {
            Debug.Log(haveTools[0]);
            if (haveTools[0])
                Debug.Log("have");
            else
                Debug.Log("have no");
        }

    }

    public void setTools(int index, bool state)
    {
        haveTools[index] = state;
        toolsUI[index].GetComponent<Image>().enabled = true;
    }

    
    



}

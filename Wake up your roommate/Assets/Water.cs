using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    public GameObject WATER;
    Collider2D WATERcoll;



    // Use this for initialization
    void Start()
    {
        WATERcoll = GetComponent<Collider2D>();





    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "you")
        {
            collision.GetComponent<You>().SetTools(4, true);
        }
        Destroy(WATER);



    }
}
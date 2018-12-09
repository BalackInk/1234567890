using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;

public class You : MonoBehaviour {

    public GameObject youObj;
    public GameObject roommate;
    public Text TextTOOFAR;
    public Text WINORLOSE;
    public GameObject HXB;
    public GameObject JJJ;
    public GameObject[] tools;
    public Sprite[] toolsI;
    public GameObject[] toolsUI;
    int HP = 100;//怎么设置上限【
    Rigidbody2D youRig;
    public bool[] haveTools;//……所以这东西的号码已经不是有没有拿到某个道具而是某个道具栏有没有道具了
    public string[] Hotkey;
    public Text youhp;
    public Text rmhp;
    //回旋镖1 尖叫鸡2 针3 锤4 水5

    int Counter =0;

    public float maxTime = 5;
    public GameObject imageU;
    float tmpTimer = 0;

    int testhp=0;

    public int Testhp
    {
        get { return testhp; }
        set {
            if (value > 100)
                testhp = 100;
            else
                testhp = value;
        }
    }


    // Use this for initialization
    void Start() {
        imageU.SetActive(false);

        youRig = youObj.GetComponent<Rigidbody2D>();
      
        tools = GameObject.FindGameObjectsWithTag("items");
        //Debug.Log(tools.Length);

        haveTools = new bool[tools.Length];
        Hotkey = new string[tools.Length];
        
        for (int i = 0; i < tools.Length; i++)
        {
            haveTools[i] = false;
            Hotkey[i] = (i + 1).ToString();
        }

    }

    // Update is called once per frame
    void Update() {
        

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            imageU.SetActive(true);
            tmpTimer = 0;
        }
        tmpTimer += Time.deltaTime;
        if (tmpTimer >= maxTime)
        {
            imageU.SetActive(false);
        }


        float Hor, Vert;
        Hor = Input.GetAxisRaw ("Horizontal");
        Vert = Input.GetAxisRaw("Vertical");
        youRig.velocity = new Vector2(Hor, Vert) * 4;
        //youRig.velocity.Set(Hor,Vert);

        if (HP > 100)
        {
            HP = 100;
        }
        if (HP < 1)
        {
            HP = 0;
        }

        if (Counter==3 && HP>0 && roommate.GetComponent<roommate>().HP>0)
        {
            WINORLOSE.text = "WIN";
        }
        if (HP <= 0 || roommate.GetComponent<roommate>().HP <= 0)
        {
            WINORLOSE.text = "LOSE";
        }


        if (Input.GetKeyDown(Hotkey[0]) && haveTools[0]) 
        {
            GameObject.Instantiate(HXB, gameObject.transform.position, Quaternion.identity);
            haveTools[0] = false;
        }
        if (Input.GetKeyDown(Hotkey[1]) && haveTools[1])
        {
            HPchange(-100);
        }
        if (Input.GetKeyDown(Hotkey[2]) && haveTools[2])
        {
            if ((transform.position - roommate.transform.position).magnitude <5)
            {
                roommate.GetComponent<roommate>().HPchangeR(-10);
                Counter++;
            }
            else
            {
                TextTOOFAR.text = "太远";//怎么让它过一会消失哦
            }
           //室友HP一次减10，离得太远不能发动
        }
        if (Input.GetKeyDown(Hotkey[3]) && haveTools[3])
        {
            if ((transform.position - roommate.transform.position).magnitude <5)
            {
                roommate.GetComponent<roommate>().HPchangeR(-100);
                Counter++;
            }
            else
            {
                TextTOOFAR.text = "太远";
            }
        }
        if (Input.GetKeyDown(Hotkey[4]) && haveTools[4])
        {
            if ((transform.position - roommate.transform.position).magnitude <5)
            {
                roommate.GetComponent<roommate>().HPchangeR(20);
                haveTools[4] = false;
                Counter++;
            }
            else
            {
                TextTOOFAR.text = "太远";
            }
        }

    }

    public void SetTools(int index, bool state)
    {
        haveTools[index] = state;
        //toolsUI[index].GetComponent<Image>().enabled = true;
    }

    public void HPchange(int a)
    {
        HP = HP + a;

        if (HP > 100)
        {
            HP = 100;
        }
        if (HP < 1)
        {
            HP = 0;
        }
        youhp.text = HP.ToString();
    }
    

  /*  public void Emmm(string objname, bool state)//当某个道具trigger的时候调用一下？
    {
     
        for (int i = 0; i < tools.Length; i++)
        {
            if (haveTools[i] == false)
            {
                haveTools[i] = true;//把i搞出来，热键是有了然后怎么办
                break;
            }
        }
        
    }*/

   



    
}
//怎么给捡起来的东西分配一个热键呢？？？？？？？？
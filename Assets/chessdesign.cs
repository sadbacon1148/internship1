using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chessdesign : MonoBehaviour {

    public int number;
    public bool check;
    public Button prefab;
    public Transform canvas;
    public GridLayoutGroup buttonframe;
    //public Button[] storebuttons;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (check==true)
        {
            check = false;
            createbutton();
        }
	}


    void destroyallbutton()
    {
        foreach (Transform child in transform) //this seems complicate maybe it's the best to use normal for and getcomponentsinchildren
        {
            Destroy(child.gameObject);
        }
    }

    void createbutton()
    {
        destroyallbutton();
        buttonframe.constraintCount = number;
        for (int i=0;i<number*number;i++)
        {
            Button clonebutton = Instantiate(prefab);
            clonebutton.transform.SetParent(canvas);
            clonebutton.name = i.ToString();


            if (number % 2 == 1)
            {
                if (i % 2 == 0)
                {
                    clonebutton.GetComponent<Image>().color = Color.black;
                }
                else { clonebutton.GetComponent<Image>().color = Color.white; }


            }
            else 
            {
                if ((i/number) % 2 == 1)
                {
                    if (i % 2 == 0)
                    {
                        clonebutton.GetComponent<Image>().color = Color.white;
                    }
                    else { clonebutton.GetComponent<Image>().color = Color.black; }

                }
                else if ((i/number) % 2 == 0)
                {
                    if (i % 2 == 0)
                    {
                        clonebutton.GetComponent<Image>().color = Color.black;
                    }
                    else { clonebutton.GetComponent<Image>().color = Color.white; }


                }


            }
            

            

        }

       // storebuttons = this.GetComponentsInChildren<Button>();

    }
}

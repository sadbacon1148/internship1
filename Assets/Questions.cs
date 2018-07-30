using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questions : MonoBehaviour {
    public Button[] button;
    public Text[] choice;
    public GameObject[] quiz;
    private int[] index;
    public button1[] btns;
    public int indexAns;
    public int randomx;
    // Use this for initialization
    void Start() {
        for (int i = 0; i < btns.Length; ++i) {
            btns[i].value = Random.Range(10, 99);
            btns[i].SetText();
        }

        indexAns = (Random.Range(0, 100)) % 4;
        btns[indexAns].ans = true;

        if (btns[indexAns].ans == true)
        {   int randomx = Random.Range(0, btns[indexAns].value);
            int y = btns[indexAns].value - randomx ;
            gameObject.GetComponentInChildren<Text>().text = randomx.ToString() + "+" + y.ToString();
        }
        
        
        
        
        
        
        
        /*for (int i = 0; i < choice.Length; i++)
        {
            choice[i].GetComponent<Text>();

        }

        if (true)
        {
            for (int a = 0; a < index.Length; a++)
            {
                int temp = Random.Range(0,3);
                index[a] = CheckNumber(temp);
            }
            //choice[index[1]];
            choice[0].text = "1";
            choice[1].text = "2";
            choice[2].text = "3";
            choice[3].text = "4";
        }*/




    }

    private int CheckNumber(int wannacheck)
    {
        bool isSame = false, isReady = false;

        while (!isReady)
        {
            foreach (int number in index) //ไล่numberในindex arrayให้หมด
            {
                if (number == wannacheck)
                {
                    isSame = true;
                    break;
                }
                else
                    isSame = false;
            }

            if (isSame == true)
            {
                if (true)
                {
                    wannacheck++;
                }
            }
        }


        return wannacheck;
    }

    
	
	// Update is called once per frame
	void Update () {
		
	}
}

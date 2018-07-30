using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button1 : MonoBehaviour {

   // public int index;
    public bool ans;
    public int value;
    public GameObject a;
    public Text b;
	
	void Start () {
       // Text textone = GetComponentInChildren<Text>(); 
        //textone.text = "1";
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetText() {
        GetComponentInChildren<Text>().text = value.ToString();
    }
}

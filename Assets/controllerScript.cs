using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerScript : MonoBehaviour {

    public Vector3 movementup;
    public Vector3 movementdown;
    public Vector3 movementleft;
    public Vector3 movementright;

    public float speed;
   
    void Start () {
        movementleft = new Vector3(30, 0, 0);
        movementright = new Vector3(-30, 0, 0);
        movementup = new Vector3(0, 0, 0); 
}
	
	
	void Update () {

        float step = speed * Time.deltaTime;

        
        if (Input.GetKey(KeyCode.LeftArrow))  
        {
            transform.Translate(movementleft * step);
            transform.Rotate(movementleft);
        }

        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            transform.Translate(movementright * step);
            transform.Rotate(movementright);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Vector3.forward()
            //transform.Translate(0,0,forward *10 * step);
            //transform.Rotate(movementup);
            



        }


    }
}

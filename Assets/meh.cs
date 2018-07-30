using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meh : MonoBehaviour
{

    public float speed;
    private Rigidbody rb;
    private Renderer materialcolour;
    public Vector3 jump;
    private Vector3 jumpdailaew = new Vector3(0, 5, 0);
    bool isGround;




    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //jump = new Vector3(0, 100, 0);
        materialcolour = GetComponent<Renderer>();
        //Color randomcolour = new Color(Random.value, Random.value, Random.value, 1.0f);
        //materialcolour.material.color = randomcolour;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

        if (isGround == true && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("spacebar");
            rb.AddForce(jump, ForceMode.Impulse);
            isGround = false;


        }


    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = true; // needs more condition because we dont want to jump on the air?
            materialcolour.material.SetColor("_Color", Color.white );
        }

        if (collision.gameObject.tag == "jump")
        {
            Debug.Log("jumpmaijump");
            rb.AddForce(jumpdailaew, ForceMode.Impulse);

        }

        if (collision.gameObject.tag == "colour")
        {
            Color randomcolour = new Color(Random.value, Random.value, Random.value, 1.0f);
            Debug.Log("oncollisionenter");
            materialcolour.material.color = randomcolour;

        }

        /* void OnTriggerStay(Collider collide)
         {
             if (collide.gameObject.tag == "colour")
             {
                 Debug.Log("ontriggerstay");
                 materialcolour.material.SetColor("_Color", Color.red);
             }


         }

         /*void OnCollisionStay(Collision what)
         {
             if (what.gameObject.tag == "colour")
             {
                 Debug.Log("changedi");
                 materialcolour.material.SetColor("_Color", Color.red);
             }
             else { materialcolour.material.SetColor("_Color",Color.white); }

         }*/


    }
}

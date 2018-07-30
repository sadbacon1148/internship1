using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomeverythinginyalife : MonoBehaviour {
    public Transform[] spawnPoints;
    public GameObject prefabplane;
    public GameObject[] temp;  
   // public GameObject[] prefabnumber;

   
    //Vector3 setPosition = new Vector3(12, 0, 0);
    // Use this for initialization
    void Start() {

        // GameObject[] gos;
        // gos = GameObject.FindGameObjectsWithTag("position");

        //Transform childposi = GetComponentsInChildren<Transform>();



        //GameObject cubeplane = Instantiate(prefab,i*setPosition,this.transform.rotation); this works
        //cubeplane.transform.position += new Vector3(12, 0, 0); not workin for some reason

        for (int i = 0; i < 3; i++)
        {
            GameObject cubeplane = Instantiate(prefabplane, spawnPoints[i].transform.position, spawnPoints[i].transform.rotation);
            // (Above) this also works but need to drag gameobject that contained fixed position in it

            temp[i] = cubeplane; // create array to store clone prefab so that we can random the object on plane to delete         
        }
        /*  for (int j = 0; j < 9; j++)
              {

                  GameObject randomobjects = Instantiate(prefabnumber[Random.Range(0, 4)],  objectposition[j].transform.position, this.transform.rotation);


          }*/

        StartCoroutine(WaitSecond());
       


    }

      
    void Update() {

        

    }

    IEnumerator WaitSecond() //this make the command in this function to waitforendofframe first 
                             //because it's gonna take sometimes to wait for prefab to initiate
    {
        yield return new WaitForEndOfFrame();
        temp[Random.Range(0, 3)].GetComponent<seperate>().OnDestroy();
    }
}


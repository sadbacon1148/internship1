using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seperate : MonoBehaviour {
    public GameObject[] prefabnumber;
    public Transform[] objectposition;
    public GameObject[] spawnObject;
    // Use this for initialization
    void Start () {
        for (int j = 0; j < 9; j++)
        {

            GameObject randomobjects = Instantiate(prefabnumber[Random.Range(0, 4)], objectposition[j].transform.position, this.transform.rotation);

            spawnObject[j] = randomobjects;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnDestroy()
    {


        Destroy(spawnObject[Random.Range(0, 9)]);
    }
}

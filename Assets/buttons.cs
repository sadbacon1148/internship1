using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttons : MonoBehaviour
{

    public int number;
    public bool create;
    public Button prefab;
    public GridLayoutGroup square;
    public Color normalC, hilightC;
    //public Button[] arr;
    public List<GameObject> list; //explains below
    //public Transform canvas; //transform uses for set a position 

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (create == true)
        {
            create = false;
            Box();
            Debug.Log("TRUE");
        }

    }


    void DeleteAll()
    {
        Debug.Log("hello");
        for (int i = 0; i < list.Count; i++)
        {
            Destroy(list[i]); // list acts just like array but more flexible// destroy will make it disappear by deleting the data inside but the ช่อง of list is still there 
            //delete all the ช่อง
        }
        list.Clear(); //need to put this after the for loop because the button will be all destroy first then clear the list
                      //otherwise only the first button will be destroy then the list is clear which means that other button didnt get to destroy yet and still display on screen
    }


    void Box()
    {
        DeleteAll(); //delete before set a new number of column
        square.constraintCount = number;

        for (int i = 0; i < number * number; i++)
        {
            Button temp = Instantiate(prefab);
            temp.transform.SetParent(this.transform); //temp.transform.parent = transform; same command as beside 
                                                      //temp.transform.SetParent(canvas); another nmethod to set canvas as parent by including public Transform canvas; on the top of script too

            temp.name = i.ToString();
            temp.GetComponent<Image>().color = hilightC;

            if (i < number || i >= ((number * number) - number) || i % number == 0 || i % number == (number - 1)) { temp.GetComponent<Image>().color = normalC; }
            list.Add(temp.gameObject); // as we set the list to store gameobject at the beginning, we need to convert temp to gameobject
        }
       // arr = this.GetComponentsInChildren<Button>();


        /*for (int i = 0; i < number; i++)
        {
            for (int j = 0; j < number; j++)
            {

                Button temp = Instantiate(prefab);
                temp.transform.SetParent(this.transform); //temp.transform.parent = transform; same command as beside 
                                                          //temp.transform.SetParent(canvas); another nmethod to set canvas as parent by including public Transform canvas; on the top of script too

                temp.name = i.ToString();
                temp.GetComponent<Image>().color = hilightC;
                if (i==0 || i==number-1 || j==0 || j==number-1) { temp.GetComponent<Image>().color = normalC; }
            }
        }*/


    }
}
    
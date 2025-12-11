using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class gameflow : MonoBehaviour
{
    public static int [] orderValue = {11111, 10001, 12101};
    public static int [] plateValue = {0, 0, 0};
    public static float [] orderTimer = {60, 60, 60};

    public static int plateNum = 0;
    public static float plateXpos = 0;

    public Transform plateSelector;

    public MeshRenderer [] currentPic;

    public Texture [] orderPics;

    public static float emptyPlateNow = -5;

    public static float totalCash = 0;

    public static float[] orderCost= {1, 2.50f, 3.50f};

    public static int createdMenuItem;

    public static int  [] FullMenu = {0, 0, 0, 0, 0, 0, 0, 0, 0};

    public static int menuIndex = 0; 

    public static int showOrder = -10;

    public Transform warriorObj;
    
    public Transform mageObj;

    public Transform bossObj;

    public static int [] unlockedClasses ={0, 0, 0, 0, 0};



    void Start()
    {
        StartCoroutine(customerSpawn());
    }


    void Update()
    {
        if (gameflow.showOrder == -1)
        {

            //orderValue[1] = FullMenu[1];

            for (int rep = 0; rep < 3; rep += 1)
            {
                if (orderValue[rep] == 11001)
                    currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[0];

                if (orderValue[rep] == 11011)
                    currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[1];

                if (orderValue[rep] == 11101)
                    currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[2];

                if (orderValue[rep] == 11111)
                    currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[3];

                if (orderValue[rep] == 12001)
                    currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[4];

                if (orderValue[rep] == 12011)
                    currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[5];

                if (orderValue[rep] == 12101)
                    currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[6];

                if (orderValue[rep] == 12111)
                    currentPic[rep].GetComponent<MeshRenderer>().material.mainTexture = orderPics[7];
            }
        }

        if (Keyboard.current.tabKey.wasPressedThisFrame)
        {
            plateNum += 1;
            plateXpos += 3;

            if (plateNum > 2)
            {
                plateNum = 0;
                plateXpos = -1;
            }
        }

        orderTimer[0] -= Time.deltaTime;
        orderTimer[1] -= Time.deltaTime;
        orderTimer[2] -= Time.deltaTime;

        plateSelector.transform.position = new Vector3(plateXpos, 0, 0);
        // Debug.Log("plateSelector position: " + plateSelector.transform.position);
    }

    IEnumerator customerSpawn()
    {
        yield return new WaitForSeconds(.5f);
        if (unlockedClasses[0] == 1)
        {
            Instantiate(warriorObj, warriorObj.position, warriorObj.rotation);
        }

        yield return new WaitForSeconds(2f);
        if (unlockedClasses[1] == 1)
        {
            Instantiate(mageObj, mageObj.position, mageObj.rotation);
        }

        yield return new WaitForSeconds(5f);
        if (unlockedClasses[2] == 1)
        {
            Instantiate(bossrObj, bossrObj.position, bossrObj.rotation);
        }


        {
            gameflow.showOrder -= Time.deltaTime;
        }

        // orderValue[0] = FullMenu[0];
        // orderValue[1] = FullMenu[0];
        // orderValue[2] = FullMenu[0];
    }
}

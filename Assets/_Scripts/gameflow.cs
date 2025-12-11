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

    void Start()
    {
        
    }


    void Update()
    {
        if (Keyboard.current.tabKey.wasPressedThisFrame)
        {
            plateNum += 1;
            plateXpos += 2;

            if (plateNum > 2)
            {
                plateNum = 0;
                plateXpos = 0;
            }
        }

        orderTimer[0] -= Time.deltaTime;
        orderTimer[1] -= Time.deltaTime;
        orderTimer[2] -= Time.deltaTime;

        plateSelector.transform.position = new Vector3(plateXpos, 0, 0);
        // Debug.Log("plateSelector position: " + plateSelector.transform.position);


    }
}

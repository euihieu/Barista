using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookmove : MonoBehaviour
{
    private int foodValue=0;
    private MeshRenderer meatMat;
    private string stillcooking = "y";


    void Start()
    {
        meatMat = GetComponent<MeshRenderer>();
        StartCoroutine(cookTimer());
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        GetComponent<Transform>().position = new Vector3(gameflow.plateXpos, .66f, 0);
        // add to the currently selected plate (fix CS0019)
        gameflow.plateValue[gameflow.plateNum] += foodValue;
        stillcooking = "n";
    }

    IEnumerator cookTimer()
    {
        yield return new WaitForSeconds(10);
        foodValue = 1000;
        if (stillcooking == "y")
        meatMat.material.color = new Color(.3f, .3f, .3f); 
        
    }
}

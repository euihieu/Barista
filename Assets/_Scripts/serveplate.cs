using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class serveplate : MonoBehaviour
{
    public int thisPlate;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (gameflow.orderValue[gameflow.plateNum] == gameflow.plateValue[gameflow.plateNum])
        {
            Debug.Log("correct"+" "+gameflow.orderTimer[gameflow.plateNum]);
        }

        gameflow.emptyPlateNow = transform.position.x;
        StartCoroutine(platereset());
    }

    IEnumerator platereset()
    {
        yield return new WaitForSeconds(.2f);
        gameflow.emptyPlateNow = -1;
        gameflow.totalCash += gameflow.orderTimer[thisPlate] * 10f;
    }
}

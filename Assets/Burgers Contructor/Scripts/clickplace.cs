using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickplace : MonoBehaviour
{
    public Transform cloneObj;
    public int foodValue;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (gameObject.name == "bunBottom")
            Instantiate(cloneObj, new Vector3(gameflow.plateXpos, .10f, 0), cloneObj.rotation);

        if (gameObject.name == "bunTop")
            Instantiate(cloneObj, new Vector3(gameflow.plateXpos, .60f, 0), cloneObj.rotation);

        if (gameObject.name == "Cheese")
            Instantiate(cloneObj, new Vector3(gameflow.plateXpos, .62f, -.05f), cloneObj.rotation);
        
        if (gameObject.name == "Bacon")
        {
            Instantiate(cloneObj, new Vector3(gameflow.plateXpos - .1f, .62f, 0), cloneObj.rotation);
            Instantiate(cloneObj, new Vector3(gameflow.plateXpos + .1f, .62f, 0), cloneObj.rotation);
        }
        
        gameflow.plateValue[gameflow.plateNum] += foodValue;

        Debug.Log(gameflow.plateValue[gameflow.plateNum]+" "+gameflow.orderValue[gameflow.plateNum]);
        
    }
}

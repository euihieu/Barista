using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meatcon : MonoBehaviour
{ 
    public Transform cloneObj;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (gameObject.name == "Cutlet")
            Instantiate(cloneObj, new Vector3(-3, .1f, 0), cloneObj.rotation);
    }
}

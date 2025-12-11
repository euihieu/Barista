using UnityEngine;

// This needs refining, told the tut 

public class menucreate : MonoBehaviour
{
    public GameObject cloneObj;
    public int foodValue;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        gameflow.createdMenuItem += foodValue;

        if (foodValue == 1000)
        {
            Debug.Log("warrior unlocked");
            gameflow.unlockedClasses[0] = 1;
        }

        if (foodValue == 100000)
        {
            Debug.Log("mage unlocked");
            gameflow.unlockedClasses[1] = 1;
        }

        if (foodValue == 1000000)
        {
            Debug.Log("boss unlocked");
            gameflow.unlockedClasses[2] = 1;
        }
        if (gameObject.name != "10000")
            Instantiate(cloneObj, new Vector3(0, -8, 38), cloneObj.transform.rotation);
        else
            Instantiate(cloneObj, new Vector3(0, -12.5f, 38), cloneObj.transform.rotation);
    }
}

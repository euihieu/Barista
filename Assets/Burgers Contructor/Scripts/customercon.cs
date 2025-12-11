using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customercon : MonoBehaviour
{
    public GameObject speechBubble;
    public float textPos;

    void Start()
    {
        GetComponent<Rigidbody>().linearVelocity = new Vector3(0, 0, -4.7f);
        StartCoroutine(stopApproach());
    }

    void Update()
    {
        if (transform.position.x > gameflow.emptyPlateNow -1 && transform.position.x < gameflow.emptyPlateNow +1)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator stopApproach()
    {
        yield return new WaitForSeconds(6.5f);
        GetComponent<Rigidbody>().linearVelocity = new Vector3(0, 0, 0);
        GetComponent<Animator>().Play("idle");

        if (gameObject.name.Contains("warr"))
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 120, 0);
            gameflow.orderValue[0] = 11001;
        }

        if (gameObject.name.Contains("mage"))
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 120, 0);
            gameflow.orderValue[1] = 1100000;
        }

        gameflow.showOrder = -1;
        Debug.Log(gameflow.showOrder);
        Instantiate(speechBubble, new Vector3(transform.position.x - 3.5f, transform.position.y + textPos, 0), Quaternion.identity, transform);
    }
}


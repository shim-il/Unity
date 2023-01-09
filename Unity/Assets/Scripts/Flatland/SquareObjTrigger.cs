using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareObjTrigger : MonoBehaviour
{
    public float speed = 5.0f;
    public int onMove = 0;

    private void OnTriggerEnter(Collider other) // Move obj down so 2d view can see. 
    {
        if(onMove < 1)
        {
            Debug.Log("Trigger");
            onMove++;
            StartCoroutine(MoveBackForth());
        }
    }

    IEnumerator MoveBackForth()
    {
        while(transform.position.z < 14.5)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            yield return null;
        }

        if(transform.position.z >= 14.5)
        {
            while(transform.position.z > 3.9)
            {
                transform.Translate(Vector3.forward * -speed * Time.deltaTime);
                yield return null;
            }
        }
        onMove = 0;
    }
}


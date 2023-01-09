using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeObjTrigger : MonoBehaviour
{
    public GameObject obj;
    public float speed = 1.0f;
    public bool inSquare = false;
    public bool outSquare = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) // Move obj down so 2d view can see. 
    {
        outSquare = false;
        inSquare = true;
        StartCoroutine(MoveDown());
    }

    IEnumerator MoveDown()
    {
        while(obj.transform.position.y > 1.6 && inSquare)
        {
            obj.transform.Translate(Vector3.up * speed * Time.deltaTime);
            yield return null;
        }
    }

    private void OnTriggerExit(Collider other) // Move obj down so 2d view can see. 
    {
        inSquare = false;
        outSquare = true;
        StartCoroutine(MoveUp());
    }

    IEnumerator MoveUp()
    {
        while(obj.transform.position.y < 6.26 && outSquare)
        {
            obj.transform.Translate(Vector3.up * -speed * Time.deltaTime);
            yield return null;
        }
    }
}

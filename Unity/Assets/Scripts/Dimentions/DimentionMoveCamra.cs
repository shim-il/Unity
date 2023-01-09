using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimentionMoveCamra : MonoBehaviour
{
    public float camreraSpeed;
    public GameObject text_togo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.Space) && text_togo.gameObject.activeSelf) && transform.position.z < 1.24 )
        {
            transform.Translate(Vector3.forward * Time.deltaTime * camreraSpeed);
        }
        
    }
}

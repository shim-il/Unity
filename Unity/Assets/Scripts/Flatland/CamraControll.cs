using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamraControll : MonoBehaviour
{
    private Vector3 offset;
    private float horizantolInput;

    public GameObject player;
    public GameObject camra_2D;
    public GameObject camra_3D;
    public float rotateCamreraSpeed;


    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
        horizantolInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, Time.deltaTime * rotateCamreraSpeed * horizantolInput);
        if (Input.GetButton("Space"))
        {
            camra_2D.SetActive(false);
            camra_3D.SetActive(true);
        }
        else
        {
            camra_2D.SetActive(true);
            camra_3D.SetActive(false);
        }
        
    }
}

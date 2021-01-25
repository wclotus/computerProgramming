using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime,0f,Input.GetAxis("Vertical")*Time.deltaTime);
        
    }
}

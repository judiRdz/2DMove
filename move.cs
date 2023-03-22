using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    //Declaramos variable para la velocidad
    float velocidad = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Codigo para q se pueda mover
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 dir = input.normalized;
        Vector3 vel = dir * velocidad * Time.deltaTime;

        transform.Translate(vel);
    }
}

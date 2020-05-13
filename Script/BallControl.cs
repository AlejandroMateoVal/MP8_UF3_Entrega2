using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{

    //Variables pubicas
    public float ballForce = 1.0f;

    //Variables privadas
    private Vector3 horizontalInput, verticalInput;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vamos a empujar la bola en la direccion que pulse el usuario

        //Calculamos el input horizotal y vertical
        horizontalInput = transform.right * Input.GetAxis("Horizontal");
        verticalInput = transform.forward * Input.GetAxis("Vertical");



            //Empujamos la bola con la fuerza (ballForce)
        GetComponent<Rigidbody>().AddForce((horizontalInput + verticalInput) * ballForce);
    }
}

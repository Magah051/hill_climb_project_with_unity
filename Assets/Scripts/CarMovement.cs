using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CarMovement : MonoBehaviour
{
    public Rigidbody2D carRig;
    public Rigidbody2D backWheelRig;
    public Rigidbody2D frontWheelRig;


    public float speed;
    public float torque;

    private float movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }

    //� utilizado para F�sica
    private void FixedUpdate()
    {
        backWheelRig.AddTorque(-movement * speed * Time.fixedDeltaTime); //Adiciona for�a a roda de tr�s
        frontWheelRig.AddTorque(-movement * speed * Time.fixedDeltaTime);//Adiciona for�a a roda da frente
        carRig.AddTorque(-movement * torque * Time.fixedDeltaTime);//Adiciona for�a ao corpo do carro

        if (transform.position.x >= 138f)
        {
            //Reiniciando o jogo
            SceneManager.LoadScene(0);
        }

    }
}

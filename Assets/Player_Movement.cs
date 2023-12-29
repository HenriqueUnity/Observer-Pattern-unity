using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    private CharacterController characterController;
    private Vector2  initialPosition;
    [SerializeField] private float speed= 2f;
    
    void Start()
    {
    characterController = GetComponent<CharacterController>();
    initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > -9 && transform.position.x <9){
     float curSpeed = speed *  Input.GetAxis("Horizontal") * Time.deltaTime;     
     characterController.Move(new Vector3(curSpeed,0,0));
        }else{
            transform.position = initialPosition;
        }
    }    

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggerMessage : MonoBehaviour
{
   private GameObject player;
   public delegate void OnPlayerApproach(float myID);
   public OnPlayerApproach PlayerApproach;
   [SerializeField] private float ID;
   [SerializeField] private float distance = 0.1f;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if( player.transform.position.x -transform.position.x  < distance &&player.transform.position.x -transform.position.x > 0){
          PlayerApproach?.Invoke(ID);
        }  
    }
    
}

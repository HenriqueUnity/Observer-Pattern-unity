using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameObserver : MonoBehaviour
{
    [SerializeField] private PlayerTriggerMessage[] Interactions;
    [SerializeField] private TextMeshProUGUI debugText;
    void Start()
    {
    for (int i = 0; i < Interactions.Length; i++)
    {
        Interactions[i].PlayerApproach += OnTriggerApprouch;
    }
    }

    
    void Update()
    {
        
    }
    public void OnTriggerApprouch(float ID){
     debugText.SetText(ID.ToString());
    }
}

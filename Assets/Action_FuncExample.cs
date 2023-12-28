using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Action_FuncExample : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI debugText;
    

    // Action tem retorno do tipo void
    // argumentos são passados dentro de <  >
    
    private Action<float> testAction;
    private float numberToSum =1;
    void Start()
    {
        testAction += Sum;
        testAction(numberToSum);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)){
            testAction(numberToSum);
        }
    }

    private void Sum(float number){

     numberToSum += number;
     debugText.SetText($"Action sum: {numberToSum}");
    }
}

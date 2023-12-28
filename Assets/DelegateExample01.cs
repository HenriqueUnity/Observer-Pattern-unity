using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DelegateExample01 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI debugText;
     private float value = 1f;

     private delegate float TestDelegate(float number);
     private TestDelegate testDelegate;

    void Start()
    {
        debugText.SetText($"Example 1 Multiply by 2 delegate: {value.ToString()}");
        testDelegate = MultiByTwo;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){

            value = testDelegate(value);
            debugText.SetText($"Example 1 Multiply by 2 delegate: {value.ToString()}");

        }
        
    }
    private float MultiByTwo(float number){
     return number * 2f;
    }
}

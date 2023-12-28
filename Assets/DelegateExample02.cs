
using TMPro;
using UnityEngine;

public class DelegateExample02 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI debugText;

    private float counter ;

    private delegate void TestDelegate();
    private TestDelegate testDelegate;


    void Start()
    {
        
        testDelegate += DebugTextRefresh;
        testDelegate += FirstLogCall;
        testDelegate += SecondLogCall;

        testDelegate();
        testDelegate -= SecondLogCall;
        testDelegate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   private void DebugTextRefresh(){    
    counter++;
    debugText.SetText($"Delegate example 2 called {counter} times"); 
   }
   private void FirstLogCall(){
    Debug.Log($"First method called: {counter} time(s)");
   }

   private void SecondLogCall(){
    Debug.Log($"Second method called: {counter} time(s)");
   }

}

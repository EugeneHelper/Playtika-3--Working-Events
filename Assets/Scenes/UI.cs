using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text TestText;
    public input inp;
    // Start is called before the first frame update
    void Start()
    {
        inp.OnInput_setUI += changeText;
    }

    void changeText()
    {
        TestText.text = "Other Text";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

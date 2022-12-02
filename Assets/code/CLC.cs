using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLC : MonoBehaviour
{
    public string s = "+";
    public int a = 12;
    public int b = 3;
    // Start is called before the first frame update
    void Start()
    {
        if (s == "+")
        {
            print(a+b);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

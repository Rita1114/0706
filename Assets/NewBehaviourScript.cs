using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Button btn;

    public Image a;
    // Start is called before the first frame update
    void Start()
    {
        Console.WriteLine("測試123");
        
        btn.onClick.AddListener(OnbtnClick);
    }
     
    public void OnbtnClick()
    {
        a.color = new Color(255, 255, 255);
        a.transform.localScale =new Vector3(1, 3, 5);
        a.transform.localPosition = new Vector3(50, 50, 50);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Standart_Ball : Ball
{     
    public Renderer color;
    public GameObject scaleChange;

    private void Start()
    {
        color = GetComponent<Renderer>();
        
    }

    private void Update()
    {
        Move();
        Jump();
        ChangeColor(); 
        ChangeSize();   
    }
    private void ChangeColor()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            color.material.color = Color.green;
        }
    }

    private void ChangeSize()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            scaleChange.transform.localScale = new Vector3(5f, 5f, 5f);
        }
    }

}

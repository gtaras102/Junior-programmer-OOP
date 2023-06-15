using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Standart_Ball : Ball // INHERITANCE
{     
    public GameObject scaleChange;
    private Renderer _color;
    
    private float _minScale = 0.5f;
    private float _maxScale = 1.5f;

    private void Start()
    {
        _color = GetComponent<Renderer>();     
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
            _color.material.color = new Color (Random.Range(0f, 1f), 
                                              Random.Range(0f, 1f), 
                                              Random.Range(0f, 1f));
        }
    }

    private void ChangeSize()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            scaleChange.transform.localScale *= Random.Range(_minScale, _maxScale);
        }
    }

}

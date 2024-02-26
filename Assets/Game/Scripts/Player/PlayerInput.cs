using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    //DRILLING
    public Action DrillingDownAction;
    public Action DrillingAction;
    public Action DrillingUpAction;
    
    public Action WeaponMainDownAction;
    public Action WeaponMainAction;
    public Action WeaponMainUpAction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //DRILLING
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DrillingDownAction?.Invoke();
        }
        if (Input.GetKey(KeyCode.Space))
        {
            DrillingAction?.Invoke();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            DrillingUpAction?.Invoke();
        }
        
        
        //MAIN WEAPON
        if (Input.GetMouseButtonDown(0))
        {
            WeaponMainDownAction?.Invoke();
        }
        if (Input.GetMouseButton(0))
        {
            WeaponMainAction?.Invoke();
        }
        if (Input.GetMouseButtonUp(0))
        {
            WeaponMainUpAction?.Invoke();
        }
    }
}

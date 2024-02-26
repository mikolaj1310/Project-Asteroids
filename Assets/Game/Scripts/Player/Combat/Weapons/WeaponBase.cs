using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType
{
    Ballistic,
    Rocket,
}

public class WeaponBase : MonoBehaviour
{
    protected WeaponType weaponType;
    
    
    // Start is called before the first frame update
    protected virtual void Start()
    {
        
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        
    }

    public virtual void FireWeaponDown()
    {
        FireWeaponFunction();
    }
    
    public virtual void FireWeapon()
    {
        FireWeaponFunction();
    }
    
    public virtual void FireWeaponUp()
    {
        FireWeaponFunction();
    }

    protected virtual void FireWeaponFunction()
    {
        
    }
}

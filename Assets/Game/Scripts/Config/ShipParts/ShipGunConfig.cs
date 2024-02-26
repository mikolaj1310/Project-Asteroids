using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ShipGun", menuName = "ScriptableObjects/ShipPart/Gun")]
public class ShipGunConfig : ShipPartConfig
{
    [SerializeField] 
    public GameObject projectile;
    
    public Transform firePoint { get; private set; }

    private WeaponType weaponType;
    // Start is called before the first frame update
    void Start()
    {
        firePoint = prefab.transform.Find("FirePoint");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

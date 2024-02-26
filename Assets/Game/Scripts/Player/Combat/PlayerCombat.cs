using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCombat : MonoBehaviour
{
    private GameDataManager gameDataManager;
    private List<GameObject> shipMainGunsObjects = new List<GameObject>();
    private List<WeaponBase> shipMainGunsScript = new List<WeaponBase>();
    // Start is called before the first frame update
    void Start()
    {
        gameDataManager = FindObjectOfType<GameDataManager>();

        gameDataManager.playerInput.WeaponMainDownAction += FireMainWeapon;
        gameDataManager.playerInput.WeaponMainAction += FireMainWeapon;
    }

    private void OnDestroy()
    {
        
        gameDataManager.playerInput.WeaponMainDownAction -= FireMainWeapon;
        gameDataManager.playerInput.WeaponMainAction -= FireMainWeapon;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FireMainWeapon()
    {
        for (int i = 0; i < shipMainGunsObjects.Count; i++)
        {
            var currentGun = shipMainGunsScript[i];
            currentGun.FireWeapon();
        }
    }

    public void AssignMainGuns(List<GameObject> guns)
    {
        foreach (var gun in guns)
        {
            shipMainGunsObjects.Add(gun);
            shipMainGunsScript.Add(gun.GetComponent<WeaponBase>());
        }
    }
}

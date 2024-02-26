using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameDataManager gameDataManager;
    private ShipAssembly shipAssembly;
    private PlayerDrilling playerDrilling;
    private PlayerCombat playerCombat;
    // Start is called before the first frame update

    private void Awake()
    {
        gameDataManager = FindObjectOfType<GameDataManager>();
        shipAssembly = GetComponent<ShipAssembly>();
        playerDrilling = gameDataManager.playerDrilling;
        playerCombat = gameDataManager.playerCombat;
        shipAssembly.AssembleShip();
    }

    void Start()
    {
        playerDrilling.SetLaserPoint(shipAssembly.laserPointRef);
        AssignShipGuns();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AssignShipGuns()
    {
        playerCombat.AssignMainGuns(shipAssembly.gunRef);
    }
}

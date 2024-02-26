using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class GameDataManager : MonoBehaviour
{
    public GameObject PlayerShip;
    public PlayerDrilling playerDrilling { get; private set; }
    public PlayerCombat playerCombat { get; private set; }
    public PlayerController playerController { get; private set; }
    public PlayerInput playerInput { get; private set; }
    
    // Start is called before the first frame update
    void Awake()
    {
        playerDrilling = PlayerShip.transform.GetComponent<PlayerDrilling>();
        playerCombat = PlayerShip.transform.GetComponent<PlayerCombat>();
        playerController = PlayerShip.transform.GetComponent<PlayerController>();
        playerInput = PlayerShip.transform.GetComponent<PlayerInput>();
    }
}

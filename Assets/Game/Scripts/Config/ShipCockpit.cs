using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "ShipCockpit", menuName = "ScriptableObjects/ShipPart/Cockpit")]
public class ShipCockpit : ShipPart
{
    //change it to load a prefab and get points based on that
    //use prefabs for others and attach their origin to pivot points
    [Header("Pivot Points")] 
    [SerializeField] private Vector3 wingL;
    [SerializeField] private Vector3 wingR;
    [SerializeField] private Vector3 engine;
    [SerializeField] private Vector3 laser;
    [SerializeField] private Vector3 gunR;
    [SerializeField] private Vector3 gunL;
    
    [Header("Assets")]
    [SerializeField] private Sprite cockpitSprite;
    
}

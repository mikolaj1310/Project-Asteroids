using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ShipCockpit", menuName = "ScriptableObjects/ShipPart/Cockpit")]
public class ShipCockpitConfig : ShipPartConfig
{
    [Header("Assets")]
    [SerializeField] private List<Sprite> cockpitSpriteVariations;

}

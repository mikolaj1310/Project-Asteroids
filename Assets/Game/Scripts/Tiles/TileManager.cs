using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public List<Sprite> AsteroidBreakList { get; private set; }
    private void Awake()
    {
        AsteroidBreakList = new List<Sprite>();
        AsteroidBreakList.Add(Resources.Load<Sprite>("Tiles/AsteroidTileBreak1"));
        AsteroidBreakList.Add(Resources.Load<Sprite>("Tiles/AsteroidTileBreak2"));
        AsteroidBreakList.Add(Resources.Load<Sprite>("Tiles/AsteroidTileBreak3"));
        AsteroidBreakList.Add(Resources.Load<Sprite>("Tiles/AsteroidTileBreak4"));
        AsteroidBreakList.Add(Resources.Load<Sprite>("Tiles/AsteroidTileBreak5"));
        AsteroidBreakList.Add(Resources.Load<Sprite>("Tiles/AsteroidTileBreak6"));
    }

    private void Update()
    {
    }
    
}

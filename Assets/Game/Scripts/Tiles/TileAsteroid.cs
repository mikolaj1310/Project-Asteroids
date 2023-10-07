using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileAsteroid : TileBase
{
    private float health = 100f;
    private List<Sprite> TileBreakSprite;
    private SpriteRenderer TileBreakRenderer;
    private TileManager tileManager;
    
    // Start is called before the first frame update
    void Start()
    {
        tileManager = GameObject.Find("GameManager").GetComponent<TileManager>();
        TileBreakSprite = tileManager.AsteroidBreakList;
        TileBreakRenderer = transform.Find("TileBreakImage").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
            Destroy(gameObject);
    }


    private void RefreshTile()
    {
        switch (health)
        {
            case < 20:
                TileBreakRenderer.sprite = TileBreakSprite[5];
                break;
            case < 36:
                TileBreakRenderer.sprite = TileBreakSprite[4];
                break;
            case < 52:
                TileBreakRenderer.sprite = TileBreakSprite[3];
                break;
            case < 68:
                TileBreakRenderer.sprite = TileBreakSprite[2];
                break;
            case < 84:
                TileBreakRenderer.sprite = TileBreakSprite[1];
                break;
            case 100:
                TileBreakRenderer.sprite = TileBreakSprite[0];
                break;
        }
    }

    public void DecrementHealth(float amount)
    {
        health -= amount;
        RefreshTile();
    }
}

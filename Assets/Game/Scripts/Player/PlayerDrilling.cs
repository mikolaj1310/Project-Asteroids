using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PlayerDrilling : MonoBehaviour
{
    private Camera mainCamera;
    [SerializeField]private Transform laserPoint;
    [SerializeField]private LineRenderer laserLineRenderer;
    [SerializeField]private LayerMask drillableLayer;
    [SerializeField]private float drillStrength;
    [SerializeField]private float drillRadious;
    
    
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            EnableLaser();
        }
        if (Input.GetMouseButton(0))
        {
            UpdateLaser();
        }
        if (Input.GetMouseButtonUp(0))
        {
            DisableLaser();
        }
    }

    private void EnableLaser()
    {
        laserLineRenderer.enabled = true;
    }
    private void UpdateLaser()
    {
        var mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        RaycastHit2D[] hits =
            Physics2D.RaycastAll(laserPoint.position, (mousePos - laserPoint.position).normalized, 100f, drillableLayer);
        Vector2 firstPointHit = mousePos;
        Transform tileHit = null;
        float closestDistance = 10000000f;

        foreach (var hit in hits)
        {
            if (Mathf.Abs(Vector2.Distance(laserPoint.position, hit.point)) < closestDistance)
            {
                closestDistance = Mathf.Abs(Vector2.Distance(laserPoint.position, hit.point));
                firstPointHit = hit.point;

                tileHit = hit.transform;
            }
            
        }

        if (tileHit != null)
        {
            Collider2D[] overlappingTiles = Physics2D.OverlapCircleAll(tileHit.position, drillRadious, drillableLayer);
            
            foreach (var overlappingTile in overlappingTiles)
            {
                //some weird behaviour and formula is bad. change later
                var distanceFromTile = Mathf.Abs(Vector3.Distance(tileHit.position, overlappingTile.transform.position) / drillRadious);
                var dist = drillStrength - distanceFromTile;
                if (dist < 0)
                    dist = 0;
                overlappingTile.gameObject.GetComponent<TileAsteroid>().DecrementHealth(dist);
            }
        }

        laserLineRenderer.SetPosition(0, laserPoint.position);
        laserLineRenderer.SetPosition(1, firstPointHit);
    }
    private void DisableLaser()
    {
        laserLineRenderer.enabled = false;
    }
    
}

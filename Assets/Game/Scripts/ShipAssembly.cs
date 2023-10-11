using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions;

public class ShipAssembly : MonoBehaviour
{
    [SerializeField] private ShipCockpit cockpit;
    [SerializeField] private List<ShipWing> wings;
    [SerializeField] private ShipEngine engine;
    [SerializeField] private List<ShipGun> guns;
    
    [SerializeField] private Transform shipPivotPoint;
    private List<Transform> wingPivots;
    private Transform enginePivot;
    private List<Transform> gunPivots;

    private GameObject cockpitRef;
    private List<GameObject> wingRef = new List<GameObject>();
    private GameObject engineRef;
    private List<GameObject> gunRef = new List<GameObject>();
    private Transform laserPointRef;

    private PlayerDrilling playerDrilling;
    
    // Start is called before the first frame update
    void Start()
    {
        playerDrilling = transform.GetComponent<PlayerDrilling>();
        AssembleShip();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AssembleShip()
    {
        wingPivots = new List<Transform>();
        gunPivots = new List<Transform>();
        cockpitRef = Instantiate(this.cockpit.prefab, shipPivotPoint);
        wingPivots.Add(cockpitRef.transform.Find("WingR"));
        wingPivots.Add(cockpitRef.transform.Find("WingL"));
        wingPivots[1].localScale = new Vector3(-1f, 1f, 1f);
        enginePivot = cockpitRef.transform.Find("Engine");
        gunPivots.Add(cockpitRef.transform.Find("GunR"));
        gunPivots.Add(cockpitRef.transform.Find("GunL"));
        laserPointRef = cockpitRef.transform.Find("LaserPoint");
        playerDrilling.SetLaserPoint(laserPointRef);
        
        for (int i = 0; i < wings.Count; i++)
        {
            wingRef.Add(Instantiate(this.wings[i].prefab, wingPivots[i]));
        }
        for (int i = 0; i < guns.Count; i++)
        {
            gunRef.Add(Instantiate(this.guns[i].prefab, gunPivots[i]));
        }

        engineRef = Instantiate(engine.prefab, enginePivot);
        //spawn cockpit as child of pivot
        //spawn wings, guns, engine, drill point as children of wing points on cockpit

    }
}

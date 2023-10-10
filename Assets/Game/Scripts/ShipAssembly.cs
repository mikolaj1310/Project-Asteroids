using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

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
    
    // Start is called before the first frame update
    void Start()
    {
        AssembleShip();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AssembleShip()
    {
        wingPivots = new List<Transform>();
        cockpitRef = Instantiate(this.cockpit.prefab, shipPivotPoint);
        wingPivots.Add(cockpitRef.transform.Find("WingR"));
        wingPivots.Add(cockpitRef.transform.Find("WingL"));
        wingPivots[1].localScale = new Vector3(-1f, 1f, 1f);
        enginePivot = cockpitRef.transform.Find("Engine");
        wingPivots.Add(cockpitRef.transform.Find("GunR"));
        wingPivots.Add(cockpitRef.transform.Find("GunL"));
        
        for (int i = 0; i < wings.Count; i++)
        {
            wingRef.Add(Instantiate(this.wings[i].prefab, wingPivots[i]));
            //wingRef[i].transform.position = wingPivots[i].position;
            
        }
        //spawn cockpit as child of pivot
        //spawn wings, guns, engine, drill point as children of wing points on cockpit

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    private Quaternion targetRotation;
    [SerializeField] private float turnSpeed;
    [SerializeField] private Camera camera;
   

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = camera.WorldToScreenPoint(transform.position);
        Vector3 dir = Input.mousePosition - pos;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        targetRotation = Quaternion.AngleAxis(angle - 90f, Vector3.forward);
 
        // Lerp to target rotation
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * turnSpeed);
    }
}
 
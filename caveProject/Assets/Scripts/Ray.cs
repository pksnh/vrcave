using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Ray : MonoBehaviour
{
    public XRController xrcontrol;

    void Update()
    {
        float f;
        
        xrcontrol.inputDevice.TryGetFeatureValue(CommonUsages.trigger, out f);

        if (f >= 0.9f)
        {
            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {

                if (hit.collider.tag == "GoStage")
                {
                    hit.transform.GetComponent<GoToPlace>().Go();
                }
            }
        }
    }
}

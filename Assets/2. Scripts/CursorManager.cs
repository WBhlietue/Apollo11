using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class CursorManager : MonoBehaviour
{
    public GameObject prefabs;
    public ARRaycastManager arcast;
    int a = 0;
    public UnityEngine.UI.Text text;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            a++;
            // text.text = a.ToString();
            List<ARRaycastHit> hits = new List<ARRaycastHit>();
            arcast.Raycast(Input.GetTouch(0).position, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);
            if (hits.Count > 0)
            {
                GameObject.Instantiate(prefabs, hits[0].pose.position, hits[0].pose.rotation);
            }
        }
    }
}

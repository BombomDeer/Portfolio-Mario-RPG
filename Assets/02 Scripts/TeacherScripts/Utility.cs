using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utility 
{
    static public bool MousePick(ref Vector3 vEnd)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
        {
            if (!hit.collider.tag.Contains("Terrain"))
                return false;
            vEnd = hit.point;
            Debug.Log(hit.collider.name);
            return true;
            
        }

        return true;
    }

}

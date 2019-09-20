using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour {
    

    private void OnMouseDrag()
    {
        Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
        // Change 2 magic nu mber into
        // The distance along the ray that caused the mouse drag
        Vector3 p = r.origin + (r.direction * 2);

        transform.position = p;
    }
}

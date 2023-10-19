using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelector : MonoBehaviour
{
    public LockOnCamera cameraController;
    public LayerMask selectableObjectsLayer;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Assuming left mouse button click.
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, selectableObjectsLayer))
            {
                Transform selectedObject = hit.transform;

                // Check if the selected object has the "Untargetable" tag.
                if (!selectedObject.CompareTag("Untargetable"))
                {
                    cameraController.SetTarget(selectedObject);
                }
            }
        }
        if (Input.GetMouseButtonDown(1)) // Assuming right mouse button click to clear the target.
        {
            cameraController.ClearTarget();
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private void Update()
    {
        InteractWithMovement();
    }

    private bool InteractWithMovement()
    {
        RaycastHit hit;
        bool hasHit = Physics.Raycast(GetMouseRay(), out hit);

        if (hasHit)
        {
            if (Input.GetMouseButton(0))
            {
                GetComponent<Mover>().StartMoveAction(hit.point);
            }

            return true;
        }

        return false;
    }
    
    private static Ray GetMouseRay()
    {
        return Camera.main.ScreenPointToRay(Input.mousePosition);
    }
    
    
}

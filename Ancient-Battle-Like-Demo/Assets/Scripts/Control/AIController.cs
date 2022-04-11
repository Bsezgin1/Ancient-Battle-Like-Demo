using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    public GameObject belongsTo = null;

    private Mover mover;
    
    void Start()
    {
        mover = GetComponent<Mover>();
    }
    
    void Update()
    {
        if(belongsTo == null) return; //idle
        
        mover.StartMoveAction(GetPositionOfHero());

        
        
    }

    private Vector3 GetPositionOfHero()
    {
        return belongsTo.transform.position;
    }
}

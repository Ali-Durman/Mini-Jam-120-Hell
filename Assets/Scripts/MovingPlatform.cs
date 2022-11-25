using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] Transform[] Positions;
    [SerializeField] private float ObjectSpeed;
    private int NextPosIndex;
    Transform NextPos;
    void Start()
    {
        NextPos = Positions[0];
    }

    void Update()
    {
        MoveGameObject();      
    }

    private void MoveGameObject()
    {
        if (transform.position == NextPos.position)
        {
            NextPosIndex++;
            if (NextPosIndex >= Positions.Length)
            {
                NextPosIndex = 0;
            }
            NextPos = Positions[NextPosIndex];
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, NextPos.position, ObjectSpeed * Time.deltaTime);
        }
    }
}

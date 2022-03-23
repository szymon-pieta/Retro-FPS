using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] Transform camPosition;

    void Update()
    {
        transform.position = camPosition.position;
    }
}

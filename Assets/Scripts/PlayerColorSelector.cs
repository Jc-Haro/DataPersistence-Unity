using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerColorSelector : MonoBehaviour
{
    [SerializeField] GameObject selectedFrame;   
    public void MoveFrame(Transform newLocation)
    {
        selectedFrame.transform.position = newLocation.position;
    }
}



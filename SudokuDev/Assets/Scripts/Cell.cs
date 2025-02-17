using System.Collections;
using System.Collections.Generic;
using Interfaces;
using UnityEngine;

public class Cell : MonoBehaviour, IInteractable, ICellUnit
{
    public void Interact()
    {
        //We'll change the number within the selected number after the check.
        throw new System.NotImplementedException();
    }
    
    public int ID { get; set; }
    public int value { get; set; }
    public bool isEmpty { get; set; }
}

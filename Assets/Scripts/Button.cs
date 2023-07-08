using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public void Increase()
    {
        StaticCounter.Count++;
        Debug.Log(StaticCounter.Count);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ChangeColor : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
  
    bool _PointrtOver = false;
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        _PointrtOver = true;
        gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        _PointrtOver = false;
        gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
    }

  
}


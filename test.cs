using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class touch : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler
{
    public GameObject obj;
    public GameObject obj2;

    Vector2 startPos;
    float baslangicAci;

    private Quaternion originalRotation;



    Vector3 startDragDir;
    Vector3 currentDragDir;
    Quaternion initialRotation;
    float angleFromStart;


    public void OnEndDrag(PointerEventData eventData)
    {
       
    }
    private float startAngle = 0;

    public void OnPointerClick(PointerEventData eventData)
    {
        
    }


    float dragAngle;
    public void OnBeginDrag(PointerEventData eventData)
    {
        obj.transform.position = eventData.position;
        var screenPos = obj.transform.position;
        var vec = new Vector3(eventData.position.x, eventData.position.y, 0f) - screenPos;
        startAngle = Mathf.Atan2(vec.y, vec.x) * Mathf.Rad2Deg;
        startAngle -= Mathf.Atan2(obj.transform.right.y, obj.transform.right.x) * Mathf.Rad2Deg;
        Debug.Log(Input.mousePosition);
    }

    public void OnDrag(PointerEventData data)
    {
        var screenPos = obj.transform.position;
        var vec = new Vector3(data.position.x, data.position.y, 0f) - screenPos;
        var angle = Mathf.Atan2(vec.y, vec.x) * Mathf.Rad2Deg;
        obj2.GetComponent<Rigidbody>().MoveRotation(Quaternion.AngleAxis(startAngle-angle, Vector3.up ));
        obj.transform.rotation = Quaternion.AngleAxis(angle - startAngle, Vector3.forward);

    }
   
}

//------------------------------------------------------------------------------------------------------------
/*
 RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 10))
        {
            Debug.Log("Did Hit");
        }

        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) *10, Color.yellow);*/

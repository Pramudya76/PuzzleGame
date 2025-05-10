using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragIMG : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public int pieceID;
    private Image image;
    public bool inSlot;
    public Transform ObjectBack;
    [HideInInspector] public bool isLooked = false;
    [HideInInspector] public Transform ParentAfterDrag;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }
    public void OnBeginDrag(PointerEventData eventData) {
        if(isLooked) return;
        Debug.Log("Begin Drag");
        inSlot = false;
        ParentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData) {
        if(isLooked) return;
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData) {
        if(!inSlot) {
            transform.SetParent(ObjectBack);
        }else {
            transform.SetParent(ParentAfterDrag);
        }
        if(isLooked) return;
        image.raycastTarget = true;
    }



}

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
    [HideInInspector] public Transform ParentAfterDrag;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }
    public void OnBeginDrag(PointerEventData eventData) {
        Debug.Log("Begin Drag");
        inSlot = false;
        ParentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData) {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData) {
        if(!inSlot) {
            transform.SetParent(ObjectBack);
        }else {
            transform.SetParent(ParentAfterDrag);
        }
        image.raycastTarget = true;
    }



}

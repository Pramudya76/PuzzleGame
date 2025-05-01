using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlacePictureSlot : MonoBehaviour, IDropHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnDrop(PointerEventData eventData) {
        if(transform.childCount == 0) {
            GameObject DragObject = eventData.pointerDrag;
            DragIMG dragIMG = DragObject.GetComponent<DragIMG>();
            dragIMG.ParentAfterDrag = transform;
            DragObject.transform.position = transform.position;
        }
    }
    
}

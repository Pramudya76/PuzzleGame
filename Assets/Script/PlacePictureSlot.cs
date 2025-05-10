using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlacePictureSlot : MonoBehaviour, IDropHandler
{
    public int slotID;
    private GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }

    public void OnDrop(PointerEventData eventData) {
        if(transform.childCount == 0) {
            GameObject DragObject = eventData.pointerDrag;
            DragIMG dragIMG = DragObject.GetComponent<DragIMG>();
            dragIMG.ParentAfterDrag = transform;
            DragObject.transform.position = transform.position;
            dragIMG.inSlot = true;
            if(dragIMG.pieceID == slotID) {
                dragIMG.isLooked = true;
                GM.pieceCorrectPlace();
            }else {
                GM.pieceWrongPlace(slotID);
            }

        }
    }
    
}

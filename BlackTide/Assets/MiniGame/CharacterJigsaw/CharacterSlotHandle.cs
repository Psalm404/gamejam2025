using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace D011
{

    public class CharacterSlotHandle : MonoBehaviour, IDropHandler
    {
        public int TOTAL = 9;

        public string slotTag;
        public void OnDrop(PointerEventData eventData)
        {
            Debug.Log("ondrop");
            Transform dragItem = null;
            CharacterDragHandle dragHandle;
            if (eventData.pointerDrag != null) { dragItem = eventData.pointerDrag.transform; Debug.Log(dragItem.name + " " + transform.name); }
             

            if (transform.childCount == 0 && dragItem.TryGetComponent<CharacterDragHandle>(out dragHandle) && dragHandle.itemTag.Equals(slotTag))
            {
                CharacterPieceCounter.Instance.pieceCount++;
                dragItem.SetParent(transform);
                dragItem.position = transform.position;
                Debug.Log("成功插入该插槽");
            }
        }

        void Start()
        {

        }

        void Update()
        {


        }
    }
}
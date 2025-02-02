using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace D011
{

    public class SlotHandle : MonoBehaviour, IDropHandler
    {
        public int TOTAL = 9;

        public string slotTag;
        public void OnDrop(PointerEventData eventData)
        {
            Transform dragItem = null;
            DragHandle dragHandle;
            if (eventData.pointerDrag != null)
                dragItem = eventData.pointerDrag.transform;

            if (transform.childCount == 0 && dragItem.TryGetComponent<DragHandle>(out dragHandle) && dragHandle.itemTag.Equals(slotTag))
            {
                PieceCounter.Instance.pieceCount++;
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
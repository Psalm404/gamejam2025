using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace D011
{

    public class DiarySlotHandle : MonoBehaviour, IDropHandler
    {
        public int TOTAL = 9;

        public string slotTag;
        public void OnDrop(PointerEventData eventData)
        {
            Transform dragItem = null;
            DiaryDragHandle dragHandle;
            if (eventData.pointerDrag != null)
                dragItem = eventData.pointerDrag.transform;

            if (transform.childCount == 0 && dragItem.TryGetComponent<DiaryDragHandle>(out dragHandle) && dragHandle.itemTag.Equals(slotTag))
            {
                DiaryPieceCounter.Instance.pieceCount++;
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
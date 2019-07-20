using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Inventory : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler//OnPointerDown꼭 필요
{
    public Image MoveIcon;
    public List<InventorySlot> slotList = new List<InventorySlot>();
    int iWorkingSlot;
    // Start is called before the first frame update
    void Start()
    {
        ResourceManager.instance.LoadIcon();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
        MoveIcon.gameObject.SetActive(true);
        MoveIcon.rectTransform.position = eventData.position;

        //MoveIcon.sprite = ResourceManager.instance.GetSprite("Heart");
        //slotList[0].OffIcon();

        Vector2 uiPos = eventData.position;//where I clicked on the ui
        //Debug.Log(uiPos);

        for(int i =0;i<slotList.Count;i++)
        {
            Debug.Log(slotList[i].rc);
            //if(slotList[i].rc.Contains(uiPos))
            //{
            //    Debug.Log(i.ToString() + "번째 슬롯 선택");
            //}
            if (uiPos.x >= slotList[i].rc.x &&
                uiPos.x <= slotList[i].rc.x + slotList[i].rc.width &&
                uiPos.y <= slotList[i].rc.y &&
                uiPos.y >= slotList[i].rc.y - slotList[i].rc.height)
            {
                string sprName = slotList[i].GetIconName();
                MoveIcon.sprite = ResourceManager.instance.GetSprite(sprName);
                slotList[i].OffIcon();
                iWorkingSlot = i;
            }
            
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Vector2 uiPos = eventData.position;
        int nTmpIndex = -1;
        for (int i = 0; i < slotList.Count; i++)
        {
            if (uiPos.x >= slotList[i].rc.x &&
                uiPos.x <= slotList[i].rc.x + slotList[i].rc.width &&
                uiPos.y <= slotList[i].rc.y &&
                uiPos.y >= slotList[i].rc.y - slotList[i].rc.height)
            {
                nTmpIndex = i;
                break;
            }
        }

        if(nTmpIndex == iWorkingSlot && nTmpIndex != -1)
        {
            slotList[iWorkingSlot].Icon.gameObject.SetActive(true);
            MoveIcon.sprite = null;
            MoveIcon.gameObject.SetActive(false);
            iWorkingSlot = -1;
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        MoveIcon.rectTransform.position = eventData.position;
    }

    public void OnDrag(PointerEventData data)
    {
        MoveIcon.rectTransform.position = data.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Vector2 uiPos = eventData.position;

        for(int i = 0;i<slotList.Count;i++)
        {
            if (uiPos.x >= slotList[i].rc.x &&
                uiPos.x <= slotList[i].rc.x + slotList[i].rc.width &&
                uiPos.y <= slotList[i].rc.y &&
                uiPos.y >= slotList[i].rc.y - slotList[i].rc.height)
            {
                //Debug.Log("sdjiofdoji"+i.ToString());

                if(slotList[i].Icon.sprite == null)
                {
                    string strWorkSpr = slotList[iWorkingSlot].Icon.sprite.name;
                    slotList[i].Icon.sprite = ResourceManager.instance.GetSprite(strWorkSpr);
                    slotList[i].Icon.gameObject.SetActive(true);

                    slotList[iWorkingSlot].Icon.sprite = null;
                    slotList[iWorkingSlot].Icon.gameObject.SetActive(false);

                    
                }
                else
                {
                    
                    string strWorkSpr = slotList[iWorkingSlot].Icon.sprite.name;
                    string tmpStr = slotList[i].Icon.sprite.name;
                    slotList[iWorkingSlot].gameObject.SetActive(true);

                    slotList[iWorkingSlot].Icon.sprite = ResourceManager.instance.GetSprite(tmpStr);
                    slotList[i].Icon.sprite = ResourceManager.instance.GetSprite(strWorkSpr);                    

                }

                MoveIcon.sprite = null;
                MoveIcon.gameObject.SetActive(false);
                iWorkingSlot = -1;
                return;
                
            }
            
        }

        slotList[iWorkingSlot].Icon.gameObject.SetActive(true);
        MoveIcon.sprite = null;
        MoveIcon.gameObject.SetActive(false);
        iWorkingSlot = -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

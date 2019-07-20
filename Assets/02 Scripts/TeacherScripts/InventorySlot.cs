using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Rect rc;
    RectTransform tr;

    public Image Icon;
    private void Awake()
    {
        tr = GetComponent<RectTransform>();
        rc.x = tr.position.x - tr.rect.width / 2;
        rc.y = tr.position.y + tr.rect.height / 2;
        rc.width = tr.rect.width;
        rc.height = tr.rect.height;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public string GetIconName()
    {
        return Icon.sprite.name;
    }

    public void OffIcon()
    {
        Icon.gameObject.SetActive(false);
    }

    public void OnIcon()
    {
        Icon.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

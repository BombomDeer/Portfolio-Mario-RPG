using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : SingleTon<ResourceManager>
{
    List<Sprite> iconList = null;

    public void LoadIcon()
    {
        if(iconList == null)
        {
            iconList = new List<Sprite>();
        }
        Sprite[] icons = Resources.LoadAll<Sprite>("Icon");
        for (int i = 0; i < icons.Length; i++)
        {
            iconList.Add(icons[i]);
        }
    }
    public Sprite GetSprite(string strName)
    {
        Sprite tmp = iconList.Find(o => (o.name == strName));
        return tmp;
    }

}

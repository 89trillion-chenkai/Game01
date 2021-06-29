using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetCardInfo : MonoBehaviour
{
    public Text name; //物体名字
    public Text price; //物品价格
    public Image itemImage; //物品图片

    //设置物品信息
    public void SetItemInfo(ItemInfo info)
    {
        name.text = info.productId.ToString(); //设置物体ID名字
        price.text = info.costGold.ToString(); //设置物体价格
        String path = "Sprites/Cards/" + info.subType; //加载路径
        itemImage.sprite = Resources.Load<Sprite>(path); //设置物体图片
    }
}

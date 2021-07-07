using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

/// <summary>
/// 卡片信息和购买UI控制
/// </summary>
public class CardDataManager : MonoBehaviour
{
    [SerializeField] private Text name; //物体名字，需拖拽
    [SerializeField] private Text price; //物品价格，需拖拽
    [SerializeField] private Image itemImage; //物品图片，需拖拽
    [SerializeField] private GameObject buyMaskImage; //购买标记图片，需拖拽
    private ItemInfo thisIteamInfo; //存储本卡片的信息

    void Start()
    {
        buyMaskImage.SetActive(false);
    }
    
    //设置物品信息
    public void SetItemInfo(ItemInfo info)
    {
        name.text = info.productId.ToString(); //设置物体ID名字
        price.text = info.costGold.ToString(); //设置物体价格
        String path = "Sprites/Cards/" + info.subType; //加载路径
        itemImage.sprite = Resources.Load<Sprite>(path); //设置物体图片
        thisIteamInfo = info; //获取本卡片的Json数据
    }

    //显示购买标记UI按钮绑定函数
    public void ShowBuyUI()
    {
        if (buyMaskImage.activeSelf == false)
        {
            buyMaskImage.SetActive(true);
            thisIteamInfo.isPurchased = 1; //更新购买信息
        }
    }
}
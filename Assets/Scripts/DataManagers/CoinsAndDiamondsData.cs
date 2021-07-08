using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

/// <summary>
/// 金币和钻石卡片的信息和购买UI管理
/// </summary>
public class CoinsAndDiamondsData : MonoBehaviour
{
    [SerializeField] private GameObject imgBuyMask; //购买标记图片，需拖拽
    private ItemInfo thisIteamInfo;  //存储本卡片的Json数据
    
    void Start()
    {
        imgBuyMask.SetActive(false);
    }
    
    //传递物品信息
    public void SendJsonMessage(ItemInfo info)
    {
        thisIteamInfo = info; //获取本卡片的Json数据
    }

    //显示购买标记UI按钮绑定函数
    public void ShowBuyUI()
    {
        if (imgBuyMask.activeSelf == false)
        {
            imgBuyMask.SetActive(true);
            thisIteamInfo.isPurchased = 1; //更新购买信息
        }
    }
}

﻿using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

/// <summary>
/// 产生商品信息卡片
/// </summary>
public class GenerateItemCard : MonoBehaviour
{
    public CoinsAndDiamondsData prefabCoins; //金币预制体，需拖拽
    public CoinsAndDiamondsData prefabDiamonds; //钻石预制体，需拖拽
    public CardDataManager prefabCards; //卡片预制体，需拖拽
    public GameObject prefabNone; //未解锁卡片预制体，需拖拽
    public Transform contentTransform; //卡片排列的背景，需拖拽
    private ItemData itemData; //存储读取的Json数据

    void Start()
    {
        itemData = JsonData.GetItem(); //获取Json数据
        LoadItem(); //加载卡片信息
    }

    //加载卡片上的物品信息
    private void LoadItem()
    {
        int num = 3 - itemData.dailyProduct.Count % 3; //统计凑成整行需要填补的卡片数

        foreach (var info in itemData.dailyProduct)
        {
            if (info.type == "1") //金币  
            {
                CoinsAndDiamondsData coin = Instantiate(prefabCoins, contentTransform, false);
                coin.SendJsonMessage(info); //传递Json数据
            }
            else if (info.type == "2") //钻石    
            {
                CoinsAndDiamondsData diamond = Instantiate(prefabDiamonds, contentTransform, false);
                diamond.SendJsonMessage(info); //传递Json数据
            }
            else if (info.type == "3") //卡牌
            {
                CardDataManager card = Instantiate(prefabCards, contentTransform, false);
                card.SetItemInfo(info); //设置物品信息
            }
        }

        if (num != 0) //生成未解锁的卡片
        {
            for (int i = 0; i < num; ++i)
            {
                Instantiate(prefabNone, contentTransform, false);
            }
        }
    }
}
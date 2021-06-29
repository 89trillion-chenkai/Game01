using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 读取Json数据
/// </summary>
[Serializable]
public class ItemInfo //数据模板类
{
    public int productId; //商品id，从0开始
    public string type; //商品类型,具体定于见RewardType.cs
    public string subType; //商品子类型，。具体定于见RewardType.cs
    public int num; //商品数量
    public int costGold; //需花费金币
    public int costGem; //需花费的钻石
    public int isPurchased; //商品是否已购买，-1和1
}


public class ItemData //数据接收类
{
    public List<ItemInfo> dailyProduct;
}


public class SimpleJson : MonoBehaviour
{
    private static ItemData data;

    private void Start()
    {
        TextAsset itemText = Resources.Load<TextAsset>("JsonData/data"); //从Resources文件夹下直接加载json文件
        string itemJson = itemText.text;
        data = JsonUtility.FromJson<ItemData>(itemJson);
    }

    //供外界获取Json信息
    public static ItemData GetItem()
    {
        return data;
    }
}
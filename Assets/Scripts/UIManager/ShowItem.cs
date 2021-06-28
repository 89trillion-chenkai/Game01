using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 现实商品卡片信息
/// </summary>
public class ShowItem : MonoBehaviour
{
    public GameObject prefabCoins; //金币预制体
    public GameObject prefabDiamonds; //钻石预制体
    public GameObject prefabCards; //卡片预制体
    public GameObject prefabNone; //未解锁卡片预制体
    public Image content; //卡片排列的背景
    private ItemData itemData; //存储读取的Json数据

    void Start()
    {
        itemData = SimpleJson.GetItem(); //获取Json数据
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
                Instantiate(prefabCoins, content.transform, false);
            }
            else if (info.type == "2") //钻石    
            {
                Instantiate(prefabDiamonds, content.transform, false);
            }
            else if (info.type == "3") //卡牌
            {
                GameObject card = Instantiate(prefabCards, content.transform, false);
                card.GetComponent<SetCardInfo>().SetItemInfo(info); //设置物品信息
            }
        }

        if (num != 0) //生成未解锁的卡片
        {
            for (int i = 0; i < num; ++i)
            {
                Instantiate(prefabNone, content.transform, false);
            }
        }
    }
}

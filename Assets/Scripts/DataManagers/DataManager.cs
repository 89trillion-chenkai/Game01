using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 更新购买信息
/// </summary>
public class DataManager : MonoBehaviour
{
    public Text id; 
    private ItemData itemData; //存储读取的Json数据
    private string textId; //卡片名称ID

    void Start()
    {
        itemData = SimpleJson.GetItem();
        textId = id.text;
    }

    //更新购买数据标记
    public void UpdateBuyData()
    {
        foreach (var item in itemData.dailyProduct)
        {
            if (item.productId.ToString() == textId)
            {
                item.isPurchased = 1; //更新购买信息
            }
        }
    }
}
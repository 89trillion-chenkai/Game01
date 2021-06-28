using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 显示购买标记
/// </summary>
public class BuyUIControl : MonoBehaviour
{
    public Image buyImage; //购买标记图片

    void Start()
    {
        buyImage.gameObject.SetActive(false);
    }

    //展示购买标记
    public void ShowBuyUI()
    {
        if (buyImage.IsActive() == false)
        {
            buyImage.gameObject.SetActive(true);
            GetComponent<DataManager>().UpdateBuyData();
        }
    }
}

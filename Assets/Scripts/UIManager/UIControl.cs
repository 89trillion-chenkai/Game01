using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 控制主界面显示
/// </summary>
public class UIControl : MonoBehaviour
{
    public Image image; //主界面图片

    void Start()
    {
        image.gameObject.SetActive(false);
    }

    //展示初始主界面
    public void ShowUI()
    {
        image.gameObject.SetActive(true);
    }
}

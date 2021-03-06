using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 控制主界面显示
/// </summary>
public class MainInterfaceUIControl : MonoBehaviour
{
    [SerializeField] private GameObject imgMainInterface; //主界面图片，需拖拽

    void Start()
    {
        imgMainInterface.SetActive(false);
    }

    //展示初始主界面
    public void ShowUI()
    {
        imgMainInterface.SetActive(true);
    }
}

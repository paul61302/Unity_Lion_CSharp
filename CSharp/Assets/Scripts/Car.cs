using UnityEngine;

// 註解：用來說明紀錄等等.. 只會在此腳本內看到
// 摘要 summary：描述此內容，會在其他腳本內看到，提高維護性與擴充性 (可讀性)
// 新增的 C# 放在專案內為藍圖
// 放在場景物件上為實體物件
/// <summary>
/// 定義汽車物件
/// </summary>
public class Car : MonoBehaviour
{
    // 認識第一個成員：欄位 field - 儲存物件資料

    // 假設
    // 資料類型
    // CC 數     - 2000        - 整數 int
    // 重量      - 100.9       - 浮點數 float
    // 品牌      - 品牌        - 字串 str
    // 剎車      - 是否開啟    - 布林值 bool - ture、false

    // 定義欄位語法：
    // 修飾詞 資料類型 欄位名稱 (指定 值);

    // 修飾詞：
    // 公開 public ：允許其他類別存取，顯示在屬性面板(Inspector)上
    // 私人 private (預設) ：不允許，不顯示

    // 預設值：
    // int、float 為 0
    // string 為 ""
    // bool 為 false
    // 欄位屬性 attribute：Unity 提供用於輔助欄位的功能
    // 語法：[屬性名稱(值)]
    // 標題 [Header("字串")]
    // 提示 [Tooltip("字串")]
    // 範圍 [Range(最小值,最大值)] - 僅限於數值類型資料 int、float


    /// <summary>
    /// 汽車的 CC 數
    /// </summary>
    [Header("汽車的 CC 數")]
    [Range(1000,10000)]
    public int cc = 2000 ;
    /// <summary>
    /// 汽車的重量
    /// </summary>
    [Header("汽車的重量")]
    [Tooltip("今天很重是吧")]
    public float weight = 100.9f ;
    /// <summary>
    /// 汽車的品牌
    /// </summary>
    [Header("汽車的品牌")]
    public string brand = "BMW" ;
    /// <summary>
    /// 汽車有沒有剎車
    /// </summary>
    [Header("汽車有沒有剎車")]
    public bool brake = false ;
}

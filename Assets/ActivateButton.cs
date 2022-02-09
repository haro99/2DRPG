using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;


using System;

public class ActivateButton : MonoBehaviour
{
    //　最初にフォーカスするゲームオブジェクト
    [SerializeField]
    private GameObject firstSelect;

    //private void Start()
    //{
    //    ActivateOrNotActivate(true);
    //}

    private void Update()
    {
        // 何かキーが押された場合
        if (Input.anyKeyDown)
        {
            foreach (KeyCode code in Enum.GetValues(typeof(KeyCode)))
            { // 検索
                if (Input.GetKeyDown(code))
                { // 入力されたキーの名前と一致した場合
                    Debug.Log(code.ToString() + " のボタンが押されたよ！！"); // コンソールに表示
                }
            }
        }
    }

    public void ActivateOrNotActivate(bool flag)
    {
        for (var i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).GetComponent<Button>().interactable = flag;
        }
        if (flag)
        {
            EventSystem.current.SetSelectedGameObject(firstSelect);
        }
    }
}

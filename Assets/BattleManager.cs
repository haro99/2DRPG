using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{
    public Text MessageText;
    public GameObject Command, Message, Enemy;
    public Character Character;
    public int hp;
    // Start is called before the first frame update
    void Start()
    {
        Character = Enemy.GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attack()
    {
        StartCoroutine(AttackCommand());
    }

    IEnumerator AttackCommand()
    {
        Command.SetActive(false);
        Message.SetActive(true);
        Attacker("プレイヤーの攻撃\n");
        yield return new WaitForSeconds(1);
        Character.Damage(5);
        yield return new WaitForSeconds(1);

    }

    public void Damage(int damagepoint)
    {
        Defense("プレイヤーに" + damagepoint + "ダメージ\n");
        //hpの表示をを更新

        hp -= damagepoint;
        if(hp<1)
        {
            hp = 0;
            Defense("プレイヤーは死んでしまいました");
        }
    }

    public void Attacker(string text)
    {
        MessageText.text = text;
    }

    public void Defense(string text)
    {
        MessageText.text += text;
    }

    public void Down()
    {
        MessageText.text += "倒した！";
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//インターフェースを継承
public class Enemy : MonoBehaviour, Character
{
    public BattleManager BattleManager;
    public string name;
    public int HP;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //インターフェース1
    public void Command()
    {
        StartCoroutine(Action());
    }

    //インターフェース2
    public void Damage(int damagepoint)
    {
        StartCoroutine(Display(damagepoint));
    }

    IEnumerator Display(int damagepoint)
    {
        HP -= damagepoint;
        string text = "まものへ" + damagepoint + "のダメージ\n";
        BattleManager.Defense(text);
        yield return new WaitForSeconds(1);
        if (HP < 1)
        {

            BattleManager.Down();
        }
        else
        {
            Command();
        }
    }

    IEnumerator Action()
    {
        if (Random.Range(0, 5) < 3)
        {
            BattleManager.Attacker("まものの攻撃！\n");
            yield return new WaitForSeconds(1);
            BattleManager.Damage(1);
        }
        else
        {
            BattleManager.Attacker("ぼーっとしている");
            yield return new WaitForSeconds(1);

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour, Character
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Command()
    {
        if (Random.Range(0, 5) < 5)
        {
            Debug.Log("プレイヤーに攻撃");
        }
        else
            Debug.Log("ファイアボールを唱えた");
    }

    public void Damage(int damagepoint)
    {
        Debug.Log(damagepoint + "のダメージを与えた");
    }
}

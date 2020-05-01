using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Enemy enemy1, enemy2;
    public Text result;
    
    [Header("血量")]    
    public int hp;

    [Header("攻擊力")]
    public int attack;

    [Header("治癒量")]
    public int cure;

    private void Start()
    {
        enemy1.hp = 200;
        enemy1.attack = 50;
        enemy1.cure = 20;

        enemy2.hp = 100;
        enemy2.attack = 20;
        enemy2.cure = 10;
    }
        
    public void TalK()
    {
        print("HI ! 我是" + gameObject.name);
    }
            
    public void Attack1()
    {
        print(gameObject.name + "發出" + attack + "的攻擊");
        enemy2.hp -= enemy1.attack;

        result.text = ("<color=#008000ff>" + "史萊姆" + "</color>" + " - 受到傷害 : " + enemy1.attack)+"\n"+
         ("<color=#008000ff>" + "史萊姆" + "</color>" + " - 血量剩下 : " + enemy2.hp);
    }
    
    public void Cure1()
    {
        print(gameObject.name + "使用治癒，回復" + cure + "血量");
        enemy1.hp += cure;

        result.text = ("<color=#000000ff>" + "蝙蝠" + "</color>" + " - 使用治癒回復 : " + enemy1.cure)+"\n"+
        ("<color=#000000ff>"+ "蝙蝠"+ "</color>" + " - 血量剩下 : " + enemy1.hp);
    }

    public void Attack2()
    {
        print(gameObject.name + "發出" + attack + "的攻擊");
        enemy1.hp -= enemy2.attack;

        result.text = ("<color=#000000ff>" + "蝙蝠" + "</color>" + " - 受到傷害 : " + enemy2.attack) + "\n" +
        ("<color=#000000ff>" + "蝙蝠" + "</color>" + " - 血量剩下 : " + enemy1.hp);
    }

    public void Cure2()
    {
        print(gameObject.name + "使用治癒，回復" + cure + "血量");
        enemy2.hp += cure;

        result.text = ("<color=#008000ff>" + "史萊姆" + "</color>" + " - 使用治癒回復 : " + enemy2.cure) + "\n" +
        ("<color=#008000ff>" + "史萊姆" + "</color>" + " - 血量剩下 : " + enemy2.hp);
    }       
}

using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Enemy enemy1, enemy2;

    
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
    }
    
    public void Cure1()
    {
        print(gameObject.name + "使用治癒，回復" + cure + "血量");
        enemy1.hp += cure;
    }

    public void Attack2()
    {
        print(gameObject.name + "發出" + attack + "的攻擊");
        enemy1.hp -= enemy2.attack;
    }

    public void Cure2()
    {
        print(gameObject.name + "使用治癒，回復" + cure + "血量");
        enemy2.hp += cure;

    }

}

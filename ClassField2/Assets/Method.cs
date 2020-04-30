using UnityEngine;

public class Method : MonoBehaviour
{
    public Enemy enemy1, enemy2;
    
    private void Start()
    {
        // 呼叫敵人 用Talk
        enemy1.TalK();
        enemy2.TalK();
        
        enemy1.hp = 200;
        enemy1.attack = 50;
        enemy1.cure = 20;
        
        enemy2.hp = 100;
        enemy2.attack = 20;
        enemy2.cure = 10;
                
    }

    
}

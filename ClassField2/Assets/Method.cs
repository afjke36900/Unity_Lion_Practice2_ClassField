using UnityEngine;

public class Method : MonoBehaviour
{
    public Enemy enemy1, enemy2, result;
    
    private void Start()
    {
        // 呼叫敵人 用Talk
        enemy1.TalK();
        enemy2.TalK();
                
    }

    
}

using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static int level01GameType;
    public static bool areHandsWashed = false;

    public static int level02Step = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        level01GameType = UnityEngine.Random.Range(1, 4);
        //1 is PILLS
        //2 is PATCH
        //3 is LIQUID
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

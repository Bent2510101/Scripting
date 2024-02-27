using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HealthByLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 5;
    public int level = 10;
    public int lives = 1;
    void Start()
    {
        print(health);
        print(level);
        print(lives);
        lives += level;
        print(lives);
        print("Level:" + 11);
        print("Lives:" + 11 + "you're alive!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

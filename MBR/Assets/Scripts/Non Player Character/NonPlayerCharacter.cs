using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonPlayerCharacter : MonoBehaviour
{
    public enum states {
        homo,
        noHomo
    };
    public bool walking;
    public bool running;
    public bool scared;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeState(states noHomo){

    }
}

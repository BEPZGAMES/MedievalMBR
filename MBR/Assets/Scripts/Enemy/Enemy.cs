using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float hp;
    public float maxHp;
    public float speed;
    public float visionArea;
    public float audibleArea;
    public float attackRange;
    public enum states{
        homo,
        noHomo
    }; 
    public bool idle;
    public bool chase;
    public bool attack;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Attack (){

    }

    void ChangeState(states homo){

    }

    void TakeDamage(){

    }

    void Die(){

    }

    IEnumerator TakingDamage(){
        yield return 0;
    }
}

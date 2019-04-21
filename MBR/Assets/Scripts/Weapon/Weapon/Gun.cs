using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gun : Weapon
{
    public float accuracy;
    public float fireRate;
    public int ammunition;
    public int currentAmo;
    public int maxAmmo;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Shoot(/*Bullet*/){

    }

    IEnumerator Reload(){
        yield return 0;
    }

    IEnumerator ShootAnimation(){
        yield return 0;
    }
}

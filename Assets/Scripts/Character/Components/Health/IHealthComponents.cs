using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IHealthComponents
{
    
    float Health {get;}
    
    float MaxHealth {get;} 
    

    

    void SetDamage(int damage);

}

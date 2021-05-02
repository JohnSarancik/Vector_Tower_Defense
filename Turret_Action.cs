using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret_Action : MonoBehaviour
{
   public Transform target;

   public GameObject[] enemies;

   public void Update(){

      enemies = GameObject.FindGameObjectsWithTag("Enemy");

      target = enemies[0].transform;

       if(Vector3.Distance(this.transform.position, target.position) < 20f){
        this.transform.LookAt(target);
        Debug.DrawLine(this.transform.position, target.position, Color.red);
        Debug.Log("in range");
       }
       else{
           Debug.Log("out of range");
           return;
        }

   }
}

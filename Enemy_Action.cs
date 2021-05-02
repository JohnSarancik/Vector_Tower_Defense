using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Action : MonoBehaviour
{
   
    public float enemy_move_speed = 0.04f;

    public Transform target;
    public Transform[] waypoints;

    public int current_waypoint = 0;

    public GameObject enemy;
    public GameObject spawnpoint;


    public void Update(){

        this.transform.position = Vector3.MoveTowards(this.transform.position, waypoints[current_waypoint].position,  enemy_move_speed / 10);

        if(Vector3.Distance(this.transform.position, waypoints[current_waypoint].position) < 0.001f){
            current_waypoint++;
        }

        if(current_waypoint == waypoints.Length){
            current_waypoint = 0;
            this.transform.position = spawnpoint.transform.position;
        }
    }
}

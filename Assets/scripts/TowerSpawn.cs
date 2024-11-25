using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawn : MonoBehaviour
{
    public List<GameObject> towers;
    int spawnID = -1;
    
    public void selectTower(int id){
        spawnID = id;
    }
    public void deselectTower(){
        spawnID = -1;
    }
}

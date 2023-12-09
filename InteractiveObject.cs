using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractiveObject : MonoBehaviour
{
   void OnTriggerEnter(Collider other) {  //При столкновении с аптечкой восстанавливается здоровье, аптечка удаляется
        if(other.gameObject.name == "KillZone") //Перезапускаем уровень
       {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       }

       
   }

   
}

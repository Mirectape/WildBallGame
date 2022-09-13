using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerNextLevel : MonoBehaviour
{
    public int levelIndexOfNextScene;
    public GameObject player;

    public void ToLevel()
    {
        SceneManager.LoadScene(levelIndexOfNextScene);
    }

    private IEnumerator ToNextLevelAfterExplosion()
    {
        yield return new WaitForSeconds(1);
        ToLevel();
    }
    private void OnCollisionEnter()
    {
        if (this.tag == "DeathTrigger")
        {
            player.GetComponent<ParticleSystem>().Play(); //Play death
            StartCoroutine(ToNextLevelAfterExplosion());
        }
        else ToLevel();
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBonusTaken : MonoBehaviour
{
    public Scoring score;

    private IEnumerator DestructionOfBonus()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider player)
    {
        if (player.tag == "Player")
        {
            this.GetComponent<Animator>().SetBool("BonusTaken", true);
            this.GetComponent<ParticleSystem>().Play();
            StartCoroutine(DestructionOfBonus());
            score.ScoreUp();
        }
    }
}

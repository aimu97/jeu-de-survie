using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterJumpTrigger : MonoBehaviour
{

    public AudioSource DoorBang;
    public AudioSource DoorJumpMusic;
    public GameObject TheMonster;
    public GameObject TheDoor;
    public AudioSource AmMusic;


    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        TheDoor.GetComponent<Animation>().Play("JumpDoorAnim");
        DoorBang.Play();
        TheMonster.SetActive(true);
        StartCoroutine(PlayJumpMusic());
    }

    IEnumerator PlayJumpMusic()
    {
        yield return new WaitForSeconds(0.4f);
        AmMusic.Stop();
        DoorJumpMusic.Play();
    }



}

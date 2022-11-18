using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public GameObject scoreText;
    public int theScore;
    public AudioSource collectSounds;

    private void OnTriggerEnter(Collider other)
    {
        collectSounds.Play();
        theScore += 50;
        scoreText.GetComponent<Text>().text = "Score:" + theScore;
        Destroy(gameObject);
    }
}

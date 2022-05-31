using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject clearText;
    public GameObject nextButton;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerControler>() != null)
        {
            clearText.SetActive(true);
            nextButton.SetActive(true);
            audioSource.Play();
            other.GetComponent<PlayerControler>().goaled = true;
        }
    }
}

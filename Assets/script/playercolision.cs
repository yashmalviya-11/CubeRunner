using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class onoBehaviourScript : MonoBehaviour
{
    public playerscript playerscript;
    public score score;
    public gamecontroler gamecontroler;
    public AudioSource audioSource;
    public AudioSource audioSource1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "collectable")
        {
            audioSource.Play();
            score.AddScore(1);
            Destroy(other.gameObject);
        }
    }
    
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="obstical")
        {
            audioSource1.Play();
            gamecontroler.GameOver();
            playerscript.enabled = false;

        }
    }
}

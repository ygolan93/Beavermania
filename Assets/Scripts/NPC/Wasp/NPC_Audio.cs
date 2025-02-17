using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class NPC_Audio : MonoBehaviour
{
    [SerializeField] AudioClip[] audioClip;
    [SerializeField] AudioSource ActionSource;

    public void Beat()
    {
        ActionSource.clip = audioClip[0];
        ActionSource.volume = 0.4f;
        ActionSource.pitch = 1f;
        ActionSource.PlayOneShot(audioClip[0]);
    }
    public void Sting()
    {
        ActionSource.clip = audioClip[1];
        //ActionSource.volume = 0.5f;
        //ActionSource.pitch = 1f;
        ActionSource.PlayOneShot(audioClip[1]);
    }
    public void Breath()
    {
        ActionSource.clip = audioClip[2];
        //ActionSource.volume = 0.5f;
        //ActionSource.pitch = 0.8f;
        ActionSource.PlayOneShot(audioClip[2]);
    }
    public void Crawling()
    {
        ActionSource.clip = audioClip[3];
        //ActionSource.volume = 0.5f;
        //ActionSource.pitch = 1f;
        ActionSource.PlayOneShot(audioClip[3]);
    }
    public void LiteSwordDamage()
    {
        ActionSource.clip = audioClip[4];
        ActionSource.volume = 0.1f;
        ActionSource.pitch = 1f;
        ActionSource.PlayOneShot(audioClip[4]);
    }
    public void HeavySwordDamage()
    {
        ActionSource.clip = audioClip[5];
        ActionSource.volume = 1f;
        ActionSource.pitch = 0.8f;
        ActionSource.PlayOneShot(audioClip[5]);
    }

}

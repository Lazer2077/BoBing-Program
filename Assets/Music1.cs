using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Music1 : MonoBehaviour
{
    private AudioSource audio;//定义声音组件
    public AudioClip Music;//放置音
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
           audio = this.GetComponent<AudioSource>();//得到声音组件
    }
     void Update()
    {
        audio.volume=slider.value;
    }
public void OnMusicControl()
{
    audio.clip = Music;
    if (audio.isPlaying == false)
    {
        audio.Play();
    }
    else
    {
        audio.Stop();
    }
    }
    // Update is called once per frame
   
}

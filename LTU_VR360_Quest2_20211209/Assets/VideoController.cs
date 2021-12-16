using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public Image imgBar;
    public float time = 3;
    public bool enter;
    public VideoPlayer videoPlayer;
    public VideoClip videoClip;

    private float timer;

    private void Update()
    {
        CountDown();
    }

    private void CountDown()
    {
        if (enter)
        {
            timer += Time.deltaTime;
            imgBar.fillAmount = timer / time;

            if (timer >= time)
            {
                videoPlayer.clip = videoClip;
            }
        }
    }

    public void OnPointerEnter()
    {
        enter = true;
    }

    public void OnPointerExit()
    {
        enter = false;
        timer = 0;
        imgBar.fillAmount = 0;
    }
}

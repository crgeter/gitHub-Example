using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IfResolution : MonoBehaviour {

    public int state;

    public int height;
        public Color default_hColor;
        public Color hColor;
    public int width;
        public Color default_wColor;
        public Color wColor;

    public Image img1;
    public Image img2;

    public bool timerActive = true;
    public float startTime = 5f;
    public float timer;

	// Use this for initialization
	void Start ()
    {
        if (img1 == null)
        {
            img1 = GetComponent<Image>();
        }

        timerActive = true;
        timer = startTime;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (timerActive)
        {
            timer -= Time.deltaTime;
            if(timer <= 0)
            {
                Debug.Log("Screen Resolution = Height: " + Screen.height + " x Width: " + Screen.width);
                ChangeColor();
                timerActive = false;
                timer = startTime;
            }
        }
        else
        {
            timerActive = true;
        }
    }

    public void ChangeColor()
    {
        if (state == 0)
        {//h
            if (Screen.height > height)
            {
                img1.color = hColor;
                Debug.Log("h success");
            }
            else
            {
                img1.color = default_hColor;
            }
        }
        else if (state == 1)
        {//w
            if (Screen.width > width)
            {
                img1.color = wColor;
                Debug.Log("w success");
            }
            else
            {
                img1.color = default_wColor;
            }
        }
        
        else
        {//h x w
            if (Screen.height > height && Screen.width > width)
            {
                img1.color = hColor;
                img2.color = wColor;
                Debug.Log("h x w success");
            }
            else
            {
                img1.color = default_hColor;
                img2.color = default_wColor;
            }
        }
    }
}

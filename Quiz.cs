using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quiz : MonoBehaviour {
    public Text question,choice1, choice2, choice3, choice4, countdown, rightAns, end, winTxt;
    public float timer = 30;
    public Slider timerBar;
    public Image timerFill;
    public int maxTime = 30, tries, winConTxt;
    public GameObject timeUp, wrong, right, quiz, quit, win, nxt, winCon, gp, b, endBtn, pauses;
    public bool pause, clear;


    public void A()
    {
        if (TrackedEvent.TrackedObjectDictionary["location1"])
        {
            right.SetActive(true);
            quiz.SetActive(false);
            Checkpoint.CheckpointClearTrue("location1clear");
        }
        else if (TrackedEvent.TrackedObjectDictionary["location2"])
        {
            wrong.SetActive(true);
            quiz.SetActive(false);
            AnsHint();
        }
        else if (TrackedEvent.TrackedObjectDictionary["location3"])
        {
            wrong.SetActive(true);
            quiz.SetActive(false);
            AnsHint();
        }
        else if (TrackedEvent.TrackedObjectDictionary["location4"])
        {
            wrong.SetActive(true);
            quiz.SetActive(false);
            AnsHint();
        }
    }

    public void B()
    {
        if (TrackedEvent.TrackedObjectDictionary["location1"])
        {
            wrong.SetActive(true);
            quiz.SetActive(false);
            AnsHint();
        }
        else if (TrackedEvent.TrackedObjectDictionary["location2"])
        {
            wrong.SetActive(true);
            quiz.SetActive(false);
            AnsHint();
        }
        else if (TrackedEvent.TrackedObjectDictionary["location3"])
        {
            wrong.SetActive(true);
            quiz.SetActive(false);
            AnsHint();
        }
        else if (TrackedEvent.TrackedObjectDictionary["location4"])
        {
            right.SetActive(true);
            quiz.SetActive(false);
            Checkpoint.CheckpointClearTrue("location4clear");
        }
    }

    public void C()
    {
        if (TrackedEvent.TrackedObjectDictionary["location1"])
        {
            wrong.SetActive(true);
            quiz.SetActive(false);
            AnsHint();
        }
        else if (TrackedEvent.TrackedObjectDictionary["location2"])
        {
            right.SetActive(true);
            quiz.SetActive(false);
            Checkpoint.CheckpointClearTrue("location2clear");
        }
        else if (TrackedEvent.TrackedObjectDictionary["location3"])
        {
            wrong.SetActive(true);
            quiz.SetActive(false);
            AnsHint();
        }
        else if (TrackedEvent.TrackedObjectDictionary["location4"])
        {
            wrong.SetActive(true);
            quiz.SetActive(false);
            AnsHint();
        }
    }

    public void D()
    {
        if (TrackedEvent.TrackedObjectDictionary["location1"])
        {
            wrong.SetActive(true);
            quiz.SetActive(false);
            AnsHint();
        }
        else if (TrackedEvent.TrackedObjectDictionary["location2"])
        {
            wrong.SetActive(true);
            quiz.SetActive(false);
            AnsHint();
        }
        else if (TrackedEvent.TrackedObjectDictionary["location3"])
        {
            right.SetActive(true);
            quiz.SetActive(false);
            Checkpoint.CheckpointClearTrue("location3clear");
        }
        else if (TrackedEvent.TrackedObjectDictionary["location4"])
        {
            wrong.SetActive(true);
            quiz.SetActive(false);
            AnsHint();
        }
    }

    public void Again()
    {
        quiz.SetActive(true);
        timeUp.SetActive(false);
        wrong.SetActive(false);
        right.SetActive(false);
        timer = 30;
        tries += 1;
    }

    public void GameHome()
    {
        SceneManager.LoadScene("game-home");
    }

    public void GameScan()
    {
        SceneManager.LoadScene("game-scan");
    }


    public void AnsHint()
    {
        if (tries >= 3)
        {
            if (TrackedEvent.TrackedObjectDictionary["location1"])
            {
                rightAns.text = "1960, Zinc";
            }
            else if (TrackedEvent.TrackedObjectDictionary["location2"])
            {
                rightAns.text = "2010, 600";
            }
            else if (TrackedEvent.TrackedObjectDictionary["location3"])
            {
                rightAns.text = "3 Wards";
            }
            else if (TrackedEvent.TrackedObjectDictionary["location4"])
            {
                rightAns.text = "Night Soil Collection";
            }
        }
        else { }
    }

    public void Win()
    {
        if (Checkpoint.CheckpointClearDictionary["location1clear"] == true && Checkpoint.CheckpointClearDictionary["location2clear"] == true && Checkpoint.CheckpointClearDictionary["location3clear"] == true && Checkpoint.CheckpointClearDictionary["location1clear"] == true)
        {
            nxt.SetActive(true);
            win.SetActive(true);
        }
    }

    public void WinNxt()
    {
        right.SetActive(false);
        winCon.SetActive(true);
    }

    public void WinConNxt()
    {
        winConTxt += 1;
    }

    public void EndGame()
    {
        win.SetActive(true);
    }

    public void Pause()
    {
        pause = true;
    }

    public void Play()
    {
        pause = false;
        pauses.SetActive(false);
    }

    // Use this for initialization
    void Start () {
        quit.SetActive(false);
        gp.SetActive(false);
        b.SetActive(false);
        winCon.SetActive(false);
        win.SetActive(false);
        timeUp.SetActive(false);
        wrong.SetActive(false);
        right.SetActive(false);
        nxt.SetActive(false);
        endBtn.SetActive(false);
        clear = false;
        pause = false;
        if (TrackedEvent.TrackedObjectDictionary["location1"])
        {
            question.text = "When is the Community Centre(Main Bulidning) built and " +
                            "what was the original material of the roofs on the third storey?";
            choice1.text = "1960, Zinc" /*right ans*/;
            choice2.text = "1940, Metal";
            choice3.text = "1953, Wood";
            choice4.text = "1974, Asphalt";
        }

        else if (TrackedEvent.TrackedObjectDictionary["location2"])
        {
            question.text = "When was the renovation for the Nursing Block completed, " +
                            "and how many hospital bed does it have?";
            choice1.text = "2009, 500";
            choice2.text = "2000, 400";
            choice3.text = "2010, 600" /*right ans*/;
            choice4.text = "2012, 350";
        }

        else if (TrackedEvent.TrackedObjectDictionary["location3"])
        {
            question.text = "How many former Tan Tock Seng Hospital's Wards are still preserved today?";
            choice1.text = "2 Wards";
            choice2.text = "6 Wards";
            choice3.text = "4 Wards";
            choice4.text = "3 Wards" /*right ans*/;
        }

        else if (TrackedEvent.TrackedObjectDictionary["location4"])
        {
            question.text = "So, before the Garden Pavillion was renovated to look like it's current state, " +
                            "what was its original purpose of it?";
            choice1.text = "Bathing Pool";
            choice2.text = "Night Soil Collection" /*right ans*/;
            choice3.text = "Oven";
            choice4.text = "Storage Room";
        }
    }

    // Update is called once per frame
    void Update () {
        if (!pause)
        {
            timer -= Time.deltaTime;
            countdown.text = Mathf.Floor(timer % 60).ToString();
            timerBar.value = Mathf.Floor(timer % 60)/maxTime;
            countdown.color = Color.Lerp(Color.red, Color.green, timer / maxTime);
            timerFill.color = Color.Lerp(Color.red, Color.green, timer / maxTime);
        }
        
        if (timer <= 0)
        {
            timeUp.SetActive(true);
            quiz.SetActive(false);
            wrong.SetActive(false);
            right.SetActive(false);
        }

        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                pauses.SetActive(true);
                Pause();
            }
        }

        if (winConTxt == 1)
        {
            b.SetActive(true);
            winTxt.text = "Ah Boy: We've finally completed the trail! " +
                "\nI’ve learnt a lot about Kwong Wai Shiu Hospital today.";
        }

        else if (winConTxt == 2)
        {
            b.SetActive(false);
            gp.SetActive(true);
            winTxt.text = "Ah Gong: Haha, so did I. Even at this age an Ah Gong like me can still learn something.";
        }

        else if (winConTxt == 3)
        {
            b.SetActive(true);
            gp.SetActive(false);
            winTxt.text = "Ah Boy: Let's come back here someday!";
        }

        else if (winConTxt == 4)
        {
            b.SetActive(false);
            gp.SetActive(true);
            winTxt.text = "Ah Gong: Okay, Okay. Next time when I have an appointment, " +
                "\nI'll bring you along.";
            endBtn.SetActive(true);
        }
    }
}
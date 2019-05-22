using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Navigation : MonoBehaviour {
    public int pg;
    public Text story, clear1, clear2, clear3, clear4, next, hint;
    public GameObject home, instruction, quit, grandpa, boy, nxt, per, storyBG;

    public void Home()
    {
        home.SetActive(true);
        instruction.SetActive(false);
    }

    public void Instruction()
    {
        instruction.SetActive(true);
        home.SetActive(false);
    }

    public void GameHome()
    {
        SceneManager.LoadScene("game-home");
    }

    public void TrackFalse()
    {
        if (TrackedEvent.TrackedObjectDictionary["location1"] == true)
        {
            TrackedEvent.SetTrackedFalse("location1");
        }
        else if (TrackedEvent.TrackedObjectDictionary["location2"] == true)
        {
            TrackedEvent.SetTrackedFalse("location2");
        }
        else if (TrackedEvent.TrackedObjectDictionary["location3"] == true)
        {
            TrackedEvent.SetTrackedFalse("location3");
        }

        else if (TrackedEvent.TrackedObjectDictionary["location4"] == true)
        {
            TrackedEvent.SetTrackedFalse("location4");
        }
    }

    public void GameScan()
    {

        TrackFalse();
        SceneManager.LoadScene("game-scan");
    }

    public void Hint1()
    {
        hint.text = "Location Community Hub – Block A" +
            "\n\nThis is the first block that you see at the entrance! " +
            "\nLook for picture of front view of the miniature models version of the buildings.";
    }

    public void Hint2()
    {
        hint.text = "Location: Nursing Home – Block B" +
            "\n\nOne of the Greenest Buildings in the area! " +
            "\nThis is the place where many Elderly Patients call home.";
    }

    public void Hint3()
    {
        hint.text = "Location: KWSH Heritage Gallery" +
            "\n\nA place where the history and heritage is preserved well. " +
            "\nWhat used to be the original wards for Tan Tock Seng Hospital.";
    }

    public void Hint4()
    {
        hint.text = "Location: The Garden Pavillion" +
            "\n\nCan be found in the most center of the Hospital, surrounded by nature. " +
            "\nA great place to chill, relax your eyes and play chess.";
    }

    public void Add()
    {
        if (TrackedEvent.TrackedObjectDictionary["location1"] == true)
        {
            pg += 1;
        }

        else if(TrackedEvent.TrackedObjectDictionary["location2"] == true)
        {
            pg += 11;
        }

        else if (TrackedEvent.TrackedObjectDictionary["location3"] == true)
        {
            pg += 1000;
        }

        else if (TrackedEvent.TrackedObjectDictionary["location4"] == true)
        {
            pg += 100;
        }
    }

    public void Minus()
    {
        if (TrackedEvent.TrackedObjectDictionary["location1"] == true && pg > 0)
        {
            pg -= 1;
        }

        else if (TrackedEvent.TrackedObjectDictionary["location2"] == true && pg > 0)
        {
            pg -= 11;
        }

        else if (TrackedEvent.TrackedObjectDictionary["location3"] == true && pg > 0)
        {
            pg -= 1000;
        }

        else if (TrackedEvent.TrackedObjectDictionary["location4"] == true && pg > 0)
        {
            pg -= 100;
        }
    }

    public void EndGame()
    {
        SceneManager.LoadScene("home");
    }

    public void QuitApp()
    {
        Application.Quit();
    }

    public void CloseQuit()
    {
        quit.SetActive(false);
    }

    // Use this for initialization
    void Start () {
        instruction.SetActive(false);
        quit.SetActive(false);
        if (Checkpoint.CheckpointClearDictionary["location1clear"] == true)
        {
            clear1.text = "Clear";
        }

        if (Checkpoint.CheckpointClearDictionary["location2clear"] == true)
        {
            clear2.text = "Clear";
        }

        if (Checkpoint.CheckpointClearDictionary["location3clear"] == true)
        {
            clear3.text = "Clear";
        }

        if (Checkpoint.CheckpointClearDictionary["location4clear"] == true)
        {
            clear4.text = "Clear";
        }
    }
	
	// Update is called once per frame
	void Update () {
         if (Application.platform == RuntimePlatform.Android)
         {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                quit.SetActive(true);
            }
         }  

        if (TrackedEvent.TrackedObjectDictionary["location1"] == true && pg == 0)
        {
            story.text = "Ah Boy: Over here, Ah Gong! We’ve reached the Kwong Wai Shiu Hospital!";
            boy.SetActive(true);
            grandpa.SetActive(false);
            storyBG.SetActive(true);
            per.SetActive(false);
            nxt.SetActive(true);
        }

        else if (TrackedEvent.TrackedObjectDictionary["location2"] == true && pg == 0)
        {
            story.text = "Ah Gong: This building looks very new. It seems like it’s newly renovated.";
            boy.SetActive(false);
            grandpa.SetActive(true);
            storyBG.SetActive(true);
            per.SetActive(false);
            nxt.SetActive(true);
        }

        else if (TrackedEvent.TrackedObjectDictionary["location3"] == true && pg == 0)
        {
            story.text = "Ah Boy: Ah Gong, did all the old buildings look like this in the past?";
            boy.SetActive(true);
            grandpa.SetActive(false);
            storyBG.SetActive(true);
            per.SetActive(false);
            nxt.SetActive(true);
        }

        else if (TrackedEvent.TrackedObjectDictionary["location4"] == true && pg == 0)
        {
            story.text = "Ah Gong: So this tree over here is actually planted by the late Mr Lee Kuan Yew, " +
                         "\nso it’s called the VIP tree.";
            boy.SetActive(true);
            grandpa.SetActive(false);
            storyBG.SetActive(true);
            per.SetActive(false);
            nxt.SetActive(true);
        }
        if (pg == 1)
        {
            grandpa.SetActive(true);
            boy.SetActive(false);
            per.SetActive(true);
            story.text = "Ah Gong: Oh, it looks pretty similar to what I’ve remembered.";

        }

        else if (pg == 2)
        {
            boy.SetActive(true);
            grandpa.SetActive(false);
            per.SetActive(true);
            story.text = "Ah Gong: Except that back then, there used to be Zinc roofs covering the 3rd floor " +
                         "\ninstead because there wasn’t enough money to build it all the way.";
        }

        else if (pg == 4)
        {
            boy.SetActive(true);
            grandpa.SetActive(false);
            per.SetActive(true);
            story.text = "Ah Boy: Huh, really? Like did you see the main Hospital being built?";
        }

        else if (pg == 5)
        {
            boy.SetActive(false);
            grandpa.SetActive(true);
            per.SetActive(true);
            story.text = "Ah Gong: Pretty much. The completion of the Main Ward Building was in 1960, " +
                        "\nback when I was a kid much younger than you.";
        }

        else if (pg == 6)
        {
            boy.SetActive(false);
            grandpa.SetActive(true);
            per.SetActive(true);
            story.text = "Ah Gong: And at that time, we certainly don’t have such fancy" +
                "\nvending machines to buy our food unlike today. ";
        }

        else if (pg == 7)
        {
            boy.SetActive(true);
            grandpa.SetActive(false);
            per.SetActive(true);
            story.text = "Ah Boy: Oh, the vending machines in the Cafeteria huh? ";
        }

        else if (pg == 8)
        {
            boy.SetActive(true);
            grandpa.SetActive(false);
            per.SetActive(true);
            next.text = "Enter Quiz";
            story.text = "Ah Boy: Well, I’m glad that we have these today. Cold drinks on a hot day are the best!";
        }

        else if (pg == 9)
        {
            if (!Checkpoint.CheckpointClearDictionary["location1clear"])
            {
               SceneManager.LoadScene("quiz");
            }
            else
            {
               SceneManager.LoadScene("game-home");
            }
            
        }

        else if (pg == 11)
        {
            boy.SetActive(true);
            grandpa.SetActive(false);
            per.SetActive(true);
            story.text = "Ah Boy: That’s because the Nursing Building only completed in 2017. ";
        }

        else if (pg == 22)
        {
            boy.SetActive(true);
            grandpa.SetActive(false);
            per.SetActive(true);
            story.text = "Ah Boy: The redevelopment project was decided back in 2010 and " +
                        "\nthey decided that the newer buildings will be built skywards to save space.";
        }

        else if (pg == 33)
        {
            boy.SetActive(true);
            grandpa.SetActive(false);
            per.SetActive(true);
            story.text = "Ah Boy: Thanks to that, the addition of the Nursing Home helped the hospital " +
                        "\nto increase beds from 350 to 624!";
           
        }

        else if (pg == 44)
        {
            boy.SetActive(false);
            grandpa.SetActive(true);
            per.SetActive(true);
            story.text = "Ah Gong:  They also found a way to make it more green as well, just take a look at windows.";
            
        }

        else if (pg == 55)
        {
            boy.SetActive(true);
            grandpa.SetActive(false);
            per.SetActive(true);
            next.text = "Enter Quiz";
            story.text = "Ah Boy: Yep, that’s way more potted plants than Ah Ma got back at home!";

        }

        else if (pg == 66)
        {
            if (!Checkpoint.CheckpointClearDictionary["location2clear"])
            {
                SceneManager.LoadScene("quiz");
            }
            else
            {
                SceneManager.LoadScene("game-scan");
            }
        }

        else if (pg == 100)
        {
            boy.SetActive(true);
            grandpa.SetActive(false);
            per.SetActive(true);
            story.text = "Ah Boy: And that one planted by PM Lee Hsien Loong?";
        }

        else if (pg == 200)
        {
            boy.SetActive(false);
            grandpa.SetActive(true);
            per.SetActive(true);
            story.text = "Ah Gong: Hmm, that’s important too but not VIP level haha!";
        }

        else if (pg == 300)
        {
            boy.SetActive(true);
            grandpa.SetActive(false);
            story.text = "Ah Boy: Say Ah Gong, what was here before all these trees were planted?";
        }

        else if (pg == 400)
        {
            boy.SetActive(false);
            grandpa.SetActive(true);
            per.SetActive(true);
            story.text = "Ah Gong: Good question. Actually this pavilion we’re sitting under used to be...... " +
                "\na night soil collection area.";
        }

        else if (pg == 500)
        {
            boy.SetActive(true);
            grandpa.SetActive(false);
            per.SetActive(true);
            story.text = "Ah Boy: Eww, isn’t night soil feces? So it was just full of shit here";
        }

        else if (pg == 600)
        {
            boy.SetActive(false);
            grandpa.SetActive(true);
            per.SetActive(true);
            story.text = "Ah Gong: Yes but please boy, the proper term from our generation is called night soil, not shit ok," +
                         "\nand ah boy, please mind your language.";
        }

        else if (pg == 700)
        {
            boy.SetActive(true);
            grandpa.SetActive(false);
            per.SetActive(true);
            story.text = "Ah Boy: Sorry Ah Gong...... Waaaa...... Still, I can't imagine that smell." +
                         "\nLuckily it’s gone now. I like walking out here without holding my nose.";
            next.text = "Enter Quiz";
        }

        else if (pg == 800)
        {
            Debug.Log(Checkpoint.CheckpointClearDictionary["location3clear"]);
            if (!Checkpoint.CheckpointClearDictionary["location3clear"])
            {
                SceneManager.LoadScene("quiz");
            }
            else
            {
                SceneManager.LoadScene("game-home");
            }
        }

        else if (pg == 1000)
        {
            boy.SetActive(false);
            grandpa.SetActive(true);
            per.SetActive(true);
            story.text = "Ah Gong: Yes, the three traditional-looking single-storey blocks are the " +
                         "\noriginal Tan Tock Seng Hospital Wards preserved to look like their original appearances.";
        }

        else if (pg == 2000)
        {
            story.text = "Ah Gong: While they still looked the same, the facilities inside have " +
                        "\nimproved vastly with modern technology ";
        }

        else if (pg == 3000)
        {
            boy.SetActive(true);
            grandpa.SetActive(false);
            per.SetActive(true);
            story.text = "Ah Boy: Yeah! Also, I heard that one of the building has been turned into a Heritage Gallery showing " +
                "\nall about the History of Kwong Wai Shiu Hospital about right in front!";
        }

        else if (pg == 4000)
        {
            story.text = "Ah Gong? Can we go in the Heritage Gallery later?";
        }

        else if (pg == 5000)
        {
            boy.SetActive(false);
            grandpa.SetActive(true);
            per.SetActive(true);
            story.text = "Ah Gong: Of course we can! Let’s go.";
            next.text = "Enter Quiz";
        }

        else if (pg == 6000)
        {
            if (!Checkpoint.CheckpointClearDictionary["location4clear"])
            {
                SceneManager.LoadScene("quiz");
            }
            else
            {
                SceneManager.LoadScene("game-home");
            }
        }
    }
}
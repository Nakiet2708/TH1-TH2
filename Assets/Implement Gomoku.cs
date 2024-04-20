using UnityEngine;
using UnityEngine.UI;
using System;

public class GomokuGame : MonoBehaviour
{
    private bool checker;
    private int plusone;
    public Text[] buttons;
    public Text btnreset = null;
    public Text btnnew = null;
    public Text msgfeedback = null;
    public Text txtx = null;
    public Text txto = null;

    public void score()
    {
        // Horizontal
        for (int i = 0; i < 10; i += 10)
        {
            for (int j = i; j < i + 10 - 2; j++)
            {
                if (buttons[j].text == "X" && buttons[j + 1].text == "X" && buttons[j + 2].text == "X" && buttons[j + 3].text == "X" && buttons[j + 4].text == "X")
                {
                    for (int k = j; k <= j + 4; k++)
                    {
                        buttons[k].color = Color.red;
                    }
                    msgfeedback.text = "X win";
                    plusone = int.Parse(txtx.text);
                    txtx.text = Convert.ToString(plusone + 1);
                }
                if (buttons[j].text == "O" && buttons[j + 1].text == "O" && buttons[j + 2].text == "O" && buttons[j + 3].text == "O" && buttons[j + 4].text == "O")
                {
                    for (int k = j; k <= j + 4; k++)
                    {
                        buttons[k].color = Color.red;
                    }
                    msgfeedback.text = "O win";
                    plusone = int.Parse(txto.text);
                    txto.text = Convert.ToString(plusone + 1);
                }
            }
        }

        // Vertical
        for (int i = 0; i < 10; i++)
        {
            for (int j = i; j <= i + 70; j += 10)
            {
                if (buttons[j].text == "X" && buttons[j + 10].text == "X" && buttons[j + 20].text == "X"&& buttons[j + 30].text == "X" && buttons[j + 40].text == "X")
                {
                    for (int k = j; k <= j + 40; k += 10)
                    {
                        buttons[k].color = Color.blue;
                    }
                    msgfeedback.text = "X win";
                    plusone = int.Parse(txtx.text);
                    txtx.text = Convert.ToString(plusone + 1);
                }
                if (buttons[j].text == "O" && buttons[j + 10].text == "O" && buttons[j + 20].text == "O" && buttons[j + 30].text == "O" && buttons[j + 40].text == "O")
                {
                    for (int k = j; k <= j + 40; k += 10)
                    {
                        buttons[k].color = Color.blue;
                    }
                    msgfeedback.text = "O win";
                    plusone = int.Parse(txto.text);
                    txto.text = Convert.ToString(plusone + 1);
                }
            }
        }

        // Diagonal
        for (int i = 0; i <= 70; i += 10)
        {
            for (int j = i; j < i + 8; j += 11)
            {
                if (buttons[j].text == "X" && buttons[j + 11].text == "X" && buttons[j + 22].text == "X"&& buttons[j + 33].text == "X" && buttons[j + 44].text == "X")
                {
                    for (int k = j; k <= j + 44; k += 11)
                    {
                        buttons[k].color = Color.green;
                    }
                    msgfeedback.text = "X win";
                    plusone = int.Parse(txtx.text);
                    txtx.text = Convert.ToString(plusone + 1);
                }
                if (buttons[j].text == "O" && buttons[j + 11].text == "O" && buttons[j + 22].text == "O" && buttons[j + 33].text == "O" && buttons[j + 44].text == "O")
                {
                    for (int k = j; k <= j + 44; k += 11)
                    {
                        buttons[k].color = Color.green;
                    }
                    msgfeedback.text = "O win";
                    plusone = int.Parse(txto.text);
                    txto.text = Convert.ToString(plusone + 1);
                }
            }
        }

        for (int i = 0; i <= 72; i += 10)
        {
            for (int j = i + 2; j < i + 10; j += 9)
            {
                if (buttons[j].text == "X" && buttons[j + 9].text == "X" && buttons[j + 18].text == "X"&& buttons[j + 27].text == "X" && buttons[j + 36].text == "X")
                {
                    for (int k = j; k <= j + 36; k += 9)
                    {
                        buttons[k].color = Color.yellow;
                    }
                    msgfeedback.text = "X win";
                    plusone = int.Parse(txtx.text);
                    txtx.text = Convert.ToString(plusone + 1);
                }
                if (buttons[j].text == "O" && buttons[j + 9].text == "O" && buttons[j + 18].text == "O" && buttons[j + 27].text == "O" && buttons[j + 36].text == "O")
                {
                    for (int k = j; k <= j + 36; k += 9)
                    {
                        buttons[k].color = Color.yellow;
                    }
                    msgfeedback.text = "O win";
                    plusone = int.Parse(txto.text);
                    txto.text = Convert.ToString(plusone + 1);
                }
            }
        }
    }

    public void button_Click(int index)
    {
        if (!checker)
        {
            buttons[index].text = "X";
            checker = true;
        }
        else
        {
            buttons[index].text = "O";
            checker = false;
        }
        score();
    }

    public void btnreset_Click()
    {
        foreach (Text btn in buttons)
        {
            btn.text = "";
            btn.color = Color.black;
            msgfeedback.text = "";
        }
    }

    public void btnnew_Click()
    {
        btnreset_Click();
        txto.text = "";
        txtx.text = "";
        msgfeedback.text = "";

    }
}
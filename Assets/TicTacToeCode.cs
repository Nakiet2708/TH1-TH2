using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TicTacToeCode : MonoBehaviour
{
    Boolean checker;
    int plusone;
    public Text btn1 = null;
    public Text btn2 = null;
    public Text btn3 = null;
    public Text btn4 = null;
    public Text btn5 = null;
    public Text btn6 = null;
    public Text btn7 = null;
    public Text btn8 = null;
    public Text btn9 = null;
    public Text btnreset = null;
    public Text btnnew = null;
    public Text msgfeedback = null;
    public Text txtx = null;
    public Text txto = null;
    public void score()
    {
        if(btn1.text=="X"&& btn2.text == "X" && btn3.text == "X")
        {
            btn1.color = Color.red;
            btn2.color = Color.red;
            btn3.color = Color.red;
            msgfeedback.text = "X win";
            plusone = int.Parse(txtx.text);
            txtx.text = Convert.ToString(plusone + 1);
        }
        //123
        if (btn1.text == "X" && btn4.text == "X" && btn7.text == "X")
        {
            btn1.color = Color.blue;
            btn4.color = Color.blue;
            btn7.color = Color.blue; 
            msgfeedback.text = "X win";
            plusone = int.Parse(txtx.text);
            txtx.text = Convert.ToString(plusone + 1);
        }
        //147
        if (btn1.text == "X" && btn5.text == "X" && btn9.text == "X")
        {
            btn1.color = Color.blue;
            btn5.color = Color.blue;
            btn9.color = Color.blue;
            msgfeedback.text = "X win";
            plusone = int.Parse(txtx.text);
            txtx.text = Convert.ToString(plusone + 1);
        }
        //159
        if (btn3.text == "X" && btn5.text == "X" && btn7.text == "X")
        {
            btn3.color = Color.green;
            btn5.color = Color.green;
            btn7.color = Color.green;
            msgfeedback.text = "X win";
            plusone = int.Parse(txtx.text);
            txtx.text = Convert.ToString(plusone + 1);
        }
        //357
        if (btn1.text == "X" && btn2.text == "O" && btn3.text == "O")
        {
            btn1.color = Color.red;
            btn2.color = Color.red;
            btn3.color = Color.red;
            msgfeedback.text = "O win";
            plusone = int.Parse(txto.text);
            txto.text = Convert.ToString(plusone + 1);
        }
        //123
        if (btn1.text == "O" && btn4.text == "O" && btn7.text == "O")
        {
            btn1.color = Color.blue;
            btn4.color = Color.blue;
            btn7.color = Color.blue;
            msgfeedback.text = "O win";
            plusone = int.Parse(txto.text);
            txto.text = Convert.ToString(plusone + 1);
        }
        //147
        if (btn1.text == "O" && btn5.text == "O" && btn9.text == "O")
        {
            btn1.color = Color.blue;
            btn5.color = Color.blue;
            btn9.color = Color.blue;
            msgfeedback.text = "O win";
            plusone = int.Parse(txto.text);
            txto.text = Convert.ToString(plusone + 1);
        }
        //159
        if (btn3.text == "O" && btn5.text == "O" && btn7.text == "O")
        {
            btn3.color = Color.green;
            btn5.color = Color.green;
            btn7.color = Color.green;
            msgfeedback.text = "O win";
            plusone = int.Parse(txto.text);
            txto.text = Convert.ToString(plusone + 1);
        }
        //357
    }
    public void btn1_Click()
    {
        if (checker == false)
        {
            btn1.text = "X";
            checker = true;
        }
        else
        {
            btn1.text = "O";
            checker = false;
        }
        score();
    }
    public void btn2_Click()
    {
        if(checker ==false)
        {
            btn2.text = "X";
            checker = true;
        }
        else
        {
            btn2.text = "O";
            checker = false;
        }
        score();
    }
    public void btn3_Click()
    {
        if (checker == false)
        {
            btn3.text = "X";
            checker = true;
        }
        else
        {
            btn3.text = "O";
            checker = false;
        }
        score();
    }
    public void btn4_Click()
    {
        if (checker == false)
        {
            btn4.text = "X";
            checker = true;
        }
        else
        {
            btn4.text = "O";
            checker = false;
        }
        score();
    }
    public void btn5_Click()
    {
        if (checker == false)
        {
            btn5.text = "X";
            checker = true;
        }
        else
        {
            btn5.text = "O";
            checker = false;
        }
        score();
    }
    public void btn6_Click()
    {
        if (checker == false)
        {
            btn6.text = "X";
            checker = true;
        }
        else
        {
            btn6.text = "O";
            checker = false;
        }
        score();
    }
    public void btn7_Click()
    {
        if (checker == false)
        {
            btn7.text = "X";
            checker = true;
        }
        else
        {
            btn7.text = "O";
            checker = false;
        }
        score();
    }
    public void btn8_Click()
    {
        if (checker == false)
        {
            btn8.text = "X";
            checker = true;
        }
        else
        {
            btn8.text = "O";
            checker = false;
        }
        score();
    }
    public void btn9_Click()
    {
        if (checker == false)
        {
            btn9.text = "X";
            checker = true;
        }
        else
        {
            btn9.text = "O";
            checker = false;
        }
        score();
    }
    public void btnreset_Click()
    {
        btn1.text = "";
        btn2.text = "";
        btn3.text = "";
        btn4.text = "";
        btn5.text = "";
        btn6.text = "";
        btn7.text = "";
        btn8.text = "";
        btn9.text = "";

        btn1.color = Color.black;
        btn2.color = Color.black;
        btn3.color = Color.black;
        btn4.color = Color.black;
        btn5.color = Color.black;
        btn6.color = Color.black;
        btn7.color = Color.black;
        btn8.color = Color.black;
        btn9.color = Color.black;
    }
    public void btnnew_Click()
    {
        btnreset_Click();
        txto.text = "";
        txtx.text = "";
    }
}




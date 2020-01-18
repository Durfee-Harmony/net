using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
  public partial class Form1 : Form
  {
    Random randomizer = new Random();
    int addend1;
    int addend2;
    int minuend;
    int subtrahend;
    int multiplicand;
    int multiplier;
    int dividend;
    int divisor;
    int timeLeft;

    public void StartTheQuiz()
    {
      // Fill in the addition problem.
      addend1 = randomizer.Next(51);
      addend2 = randomizer.Next(51);
      leftAdd.Text = addend1.ToString();
      rightAdd.Text = addend2.ToString();
      sumAdd.Value = 0;
      // Fill in the subtraction problem.
      minuend = randomizer.Next(1, 101);
      subtrahend = randomizer.Next(1, minuend);
      leftMinus.Text = minuend.ToString();
      rightMinus.Text = subtrahend.ToString();
      sumMinus.Value = 0;
      // Fill in the multiplication problem.
      multiplicand = randomizer.Next(2, 11);
      multiplier = randomizer.Next(2, 11);
      leftMultiply.Text = multiplicand.ToString();
      rightMultiply.Text = multiplier.ToString();
      sumMultiply.Value = 0;
      // Fill in the division problem.
      divisor = randomizer.Next(2, 11);
      int temporaryQuotient = randomizer.Next(2, 11);
      dividend = divisor * temporaryQuotient;
      leftDivide.Text = dividend.ToString();
      rightDivide.Text = divisor.ToString();
      sumDivide.Value = 0;
      // Start the timer.
      timeLeft = 30;
      timeLabel.Text = "30 seconds";
      timer1.Start();
    }

    private bool CheckTheAnswer()
    {
      if ((addend1 + addend2 == sumAdd.Value)
        && (minuend - subtrahend == sumMinus.Value)
        && (multiplicand * multiplier == sumMultiply.Value)
        && (dividend / divisor == sumDivide.Value))
        return true;
      else
        return false;
    }

    public Form1()
    {
      InitializeComponent();
      date.Text = DateTime.Now.ToString("dd MMMM yyyy");
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    private void startButton_Click(object sender, EventArgs e)
    {
      StartTheQuiz();
      startButton.Enabled = false;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (CheckTheAnswer())
      {
        // If CheckTheAnswer() returns true
        timer1.Stop();
        MessageBox.Show("You got all the answers right!",
                        "Congratulations!");
        startButton.Enabled = true;
      } else if (timeLeft > 0)
      {
        // Display the new time left
        timeLeft = timeLeft - 1;
        timeLabel.Text = timeLeft + " seconds";
        if (timeLeft < 6)
        {
          timeLabel.BackColor = Color.Red;
        }
      }
      else
      {
        // If the user ran out of time
        timer1.Stop();
        timeLabel.Text = "Time's up!";
        MessageBox.Show("You didn't finish in time.", "Sorry");
        sumAdd.Value = addend1 + addend2;
        sumMinus.Value = minuend - subtrahend;
        sumMultiply.Value = multiplicand * multiplier;
        sumDivide.Value = dividend / divisor;
        startButton.Enabled = true;
      }
    }

    private void answer_Enter(object sender, EventArgs e)
    {
      // Select the whole answer in the NumericUpDown control.
      NumericUpDown answerBox = sender as NumericUpDown;

      if (answerBox != null)
      {
        int lengthOfAnswer = answerBox.Value.ToString().Length;
        answerBox.Select(0, lengthOfAnswer);
      }
    }
  }
}

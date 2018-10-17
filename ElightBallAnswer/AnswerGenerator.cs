using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElightBallAnswer
{
    class AnswerGenerator
    {
        string[] answers = new string[]
        {
            "Ask Again later","Can't  Predict Now","Without a Doubt",
            "Is Decidely so","Concentrate and Ask Again","My sources say no",
            "Yes,Definitely ","Don't Count on it","Signs Point to Yes",
            "Better Not Tell You Now","Outlook Not So Good","Most Likely",
            "Very Doubtful","As I see It,Yes","My Reply is NO","It is Certain",
            "Yes","You May Rely On It","Outlook Good","Reply Hazy Try Again"
        };


        public string GetRandomAnswer(string question)
        {
            Random random = new Random();

            return answers[random.Next(0, answers.Length - 1)];
        }
    }
}

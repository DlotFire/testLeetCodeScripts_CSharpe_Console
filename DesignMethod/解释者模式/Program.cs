using System;

namespace DesignMethod.InterpreterPattern
{
    public class Program : OpenDesign
    {
        public override void Open()
        {
            string englist = "This is an apple.";
            string chinese = Translator.Translate(englist);
            Console.WriteLine(chinese);
        }
    }
}
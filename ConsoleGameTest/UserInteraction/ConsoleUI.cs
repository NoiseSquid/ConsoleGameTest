using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameTest.UserInteraction
{
    internal class ConsoleUI
    {
        public void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }

        public int ForceOptionSelect(List<Option> options)
        {
            int output = -1;
            while (true)
            {
                output = OptionSelect(options);
                if (output != -1)
                {
                    return output;
                }
            }
        }

        public int OptionSelect(List<Option> options)
        {
            for (int i = 0; i < options.Count; i++)
            {
                ShowMessage(string.Format("{0}. {1}", i + 1, options[i].Display));
            }
            ShowMessage("");

            int selection = __GetNumberSelection(options.Count);
            if (selection > -1)
            {
                return selection - 1;
            }
            else
            {
                return -1;
            }
        }



        private int __GetNumberSelection(int numOptions)
        {
            var userInput = __AwaitInput();
            if (Int32.TryParse(userInput, out int converted))
            {
                if (converted >= 1 && converted <= numOptions)
                {
                    return converted;
                }
                else
                {
                    ShowMessage("Invalid selection - option out of range");
                }
            }
            else
            {
                ShowMessage("Invalid selection - non-number entered");
            }
            return -1;
        }

        private string __AwaitInput()
        {
            Console.Write(">>> ");
            string? output = Console.ReadLine();
            if (output == null)
                return "";
            else
                return output;
        }
    }
}

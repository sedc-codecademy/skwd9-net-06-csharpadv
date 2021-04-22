using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.Examples
{
    public class InputParser : BaseParser, IInputParser
    {
        public int ToInt(int min, int max)
        {
            while (true)
            {
                string input = GetInputFromScreen($"Please enter number between {min} and {max}");
                try
                {
                    int parseValue = int.Parse(input);
                    if (parseValue >= min && parseValue <= max)
                    {
                        return parseValue;
                    }
                    throw new Exception();
                }
                catch (ArgumentNullException)
                {
                    // proper message
                }
                catch (FormatException)
                {
                    // proper message
                }
                catch (OverflowException)
                {
                    // proper message
                }
                catch (Exception)
                {
                    // proper message
                }
            }
        }
    }
}

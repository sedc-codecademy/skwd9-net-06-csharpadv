using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class02.Classses.Services
{
    public class InputService
    {
        public int GetIntegerInput(int min, int max)
        {
            while (true)
            {
                string input = Console.ReadLine();
                try
                {
                    int parseValue = int.Parse(input);
                    if(parseValue >= min && parseValue <= max)
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

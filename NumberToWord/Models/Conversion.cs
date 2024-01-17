using NumberToWords.Models;
using System.Collections.Generic;

namespace NumberToWords.Models
{
  public class Conversion
  {
    public int ConversionNum {get; set;}

    public Conversion(int userNum)
    {
      ConversionNum = userNum;
    }

    public int CheckNumLength()
    {
      char[] digitArray = ConversionNum.ToString().ToCharArray();  
      return digitArray.Length;
    }
    public string Dictionary(int userNum) {
      Dictionary<int, string> Thousands = new Dictionary<int, string>(){
        {1, "one thousand"}, {2, "two thousand"}, {3, "three thousand"}, {4,"four thousand"}, {5, "five thousand"}, {6, "six thousand"}, {7,"seven thousand"}, {8, "eight thousand"}, {9, "nine thousand"}
      };
      Dictionary<int, string> Hundreds = new Dictionary<int, string>(){
        {1, "one hundred"}, {2, "two hundred"}, {3,"three hundred"}, {4, "four hundred"}, {5, "five hundred"}, {6, "six hundred"}, {7, "seven hundred"}, {8, "eight hundred"}, {9, "nine hundred"}
      };
      Dictionary<int, string> Tens = new Dictionary<int, string>() {
        {2,"twenty"}, {3,"thirty"}, {4,"forty"}, {5,"fifty"}, {6,"sixty"}, {7,"seventy"}, {8,"eighty"}, {9,"ninety"}
      };
      Dictionary<int, string> Teens = new Dictionary<int, string>() {
        {0,"ten"}, {1,"eleven"}, {2,"twelve"}, {3,"thirteen"}, {4,"fourteen"}, {5,"fifteen"}, {6,"sixteen"}, {7,"seventeen"}, {8,"eighteen"}, {9,"nineteen"}
      };
      Dictionary<int, string> Ones = new Dictionary<int, string>() {
        {0,"zero"}, {1,"one"}, {2,"two"}, {3,"three"}, {4,"four"}, {5,"five"}, {6,"six"}, {7,"seven"}, {8,"eight"}, {9,"nine"}
      };
      
      int length = CheckNumLength();
      if (length == 4)
      {
        char[] digitArray = ConversionNum.ToString().ToCharArray();
        int firstDigit = int.Parse(digitArray[0].ToString());
        int secondDigit = int.Parse(digitArray[1].ToString());
        int thirdDigit = int.Parse(digitArray[2].ToString());
        int fourthDigit = int.Parse(digitArray[3].ToString());
        if(thirdDigit == 1)
        {
          return Thousands[firstDigit] + " " + Hundreds[secondDigit] + " " + Teens[fourthDigit];
        }
        else
        {
          return Thousands[firstDigit] + " " + Hundreds[secondDigit] + " " + Tens[thirdDigit] + " " + Ones[fourthDigit];
        }
      }
      else if(length == 3)
      {
        char[] digitArray = ConversionNum.ToString().ToCharArray();
        int firstDigit = int.Parse(digitArray[0].ToString());
        int secondDigit = int.Parse(digitArray[1].ToString());
        int thirdDigit = int.Parse(digitArray[2].ToString());
        if(secondDigit == 1)
        {
          return Hundreds[firstDigit] + " " + Teens[thirdDigit];
        }
        else
        {
          return Hundreds[firstDigit] + " " + Tens[secondDigit] + " " + Ones[thirdDigit];
        }
      }
      else if(length == 2)
      {
        char[] digitArray = ConversionNum.ToString().ToCharArray();
        int firstDigit = int.Parse(digitArray[0].ToString());
        int secondDigit = int.Parse(digitArray[1].ToString());
        if(firstDigit == 1) 
        {
          return Teens[secondDigit];
        }
        else
        {
          return Tens[firstDigit] + " " + Ones[secondDigit];
        }
      }
      else if(length == 1)
      {
    
        return Ones[userNum];
      }
      else
      {
        return "";
      }
    }
  } 
}
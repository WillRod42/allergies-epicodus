using System;
using System.Collections.Generic;

namespace Allergies
{
  public class AllergiesMain
  {
    public List<string> GetAllergies(int allergyScore)
    {
      if (allergyScore == 0)
      {
        return new List<string>() { "none" };
      }
      else
      {
        List<string> allergies = new List<string>();
        
        if (allergyScore >= 128)
        {
          allergies.Add("Cats");
          allergyScore -= 128;
        }
        if (allergyScore >= 64)
        {
          allergies.Add("Pollen");
          allergyScore -= 64;
        }
        if (allergyScore >= 32)
        {
          allergies.Add("Chocolate");
          allergyScore -= 32;
        }
        if (allergyScore >= 16)
        {
          allergies.Add("Tomatoes");
          allergyScore -= 16;
        }
        if (allergyScore >= 8)
        {
          allergies.Add("Strawberries");
          allergyScore -= 8;
        }
        if (allergyScore >= 4)
        {
          allergies.Add("Shellfish");
          allergyScore -= 4;
        }
        if (allergyScore >= 2)
        {
          allergies.Add("Peanuts");
          allergyScore -= 2;
        }
        if (allergyScore >= 1)
        {
          allergies.Add("Eggs");
          allergyScore -= 1;
        }
        
        return allergies;
      }
    }
  }
}
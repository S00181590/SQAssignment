using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarInsurance.Models;

namespace CarInsurance
{
    public class Calculator
    {
        private float Premium;

        private int age;

        private string statement;

        public void CalculateInsurance(Client C)
        {
            Premium = 0;

            age = 0;

            statement = "";

            age = DateTime.Now.Year - C.DOB.Year;

            if(age >= 18)
            {
                if (age <= 18 && age <= 25)
                {
                    if (C.Insurance == Client.insurancetype.ThirdParty)
                    {
                        Premium += (12.5f / 100) * C.carValue;
                    }
                    else if (C.Insurance == Client.insurancetype.Comprehensive)
                    {
                        Premium += (14f / 100) * C.carValue;
                    }
                }
                else
                {

                    if (C.Insurance == Client.insurancetype.ThirdParty)
                    {
                        Premium += (2.5f / 100) * C.carValue;
                    }
                    else if (C.Insurance == Client.insurancetype.Comprehensive)
                    {
                        Premium += (4f / 100) * C.carValue;
                    }

                }

                switch(C.PenaltyPoints)
                {
                    case 0:
                        break;
                    case 1:
                        Premium += 100;
                        break;
                    case 2:
                        Premium += 100;
                        break;
                    case 3:
                        Premium += 100;
                        break;
                    case 4:
                        Premium += 100;
                        break;
                    case 5:
                        Premium += 200;
                        break;
                    case 6:
                        Premium += 200;
                        break;
                    case 7:
                        Premium += 200;
                        break;
                    case 8:
                        Premium += 300;
                        break;
                    case 9:
                        Premium += 300;
                        break;
                    case 10:
                        Premium += 300;
                        break;
                    case 11:
                        Premium += 400;
                        break;
                    case 12:
                        Premium += 400;
                        break;
                    default:
                        statement = "No Quote Possible";
                        break;

                }
            }
            else
            {
                statement = "No Quote Possible";
            }

         
        }
    }
}
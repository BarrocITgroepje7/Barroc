using Barroc_it;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Barroc
{
    class AreFieldsValid
    {
         static public bool FieldsValid(Form1 form1)
        {
            bool validFields = false;
            foreach (object obj in form1.Controls)
            {
                if (((Control)obj).Name.Contains("Email") && ((Control)obj).Name.Contains("tb"))
                {
                    string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                      @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                      @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                    if (isRegexValid(((TextBox)obj).Text, strRegex))
                    {
                        validFields = true;
                    }
                    else
                    {
                        validFields = false;
                        break;
                    }
                }
                else if (((Control)obj).Name.Contains("Postalcode") && ((Control)obj).Name.Contains("tb"))
                {
                    string strRegex = @"^([1-9][0-9][0-9][0-9][a-zA-Z][a-zA-Z])$";

                    if (isRegexValid(((TextBox)obj).Text, strRegex))
                    {
                        validFields = true;
                    }
                    else
                    {
                        strRegex = @"^([1-9][0-9][0-9][0-9] [a-zA-Z][a-zA-Z])$";
                        if (isRegexValid(((TextBox)obj).Text, strRegex))
                        {
                            validFields = true;
                        }
                        else
                        {
                            validFields = false;
                            break;
                        }
                    }
                }
                else if (((Control)obj).Name.Contains("Phone") && ((Control)obj).Name.Contains("tb"))
                {
                    //string strRegex = @"^([0-9][0-9] [0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9])$";
                    string strRegex = @"^([0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9])$";
                    if (isRegexValid(((TextBox)obj).Text, strRegex))
                    {
                        validFields = true;
                    }
                    else
                    {
                        validFields = false;
                        break;
                    }
                }
            }
            return validFields;
        }

        static private bool isRegexValid(string data, string regex)
        {
            Regex reg = new Regex(regex);
            return reg.IsMatch(data);
        }
    }
}


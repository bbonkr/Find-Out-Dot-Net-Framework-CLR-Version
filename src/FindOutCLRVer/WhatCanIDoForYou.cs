using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FindOutCLRVer
{
    public class WhatCanIDoForYou
    {
        public string CheckClrVersion(string filePath)
        {
            if (String.IsNullOrEmpty(filePath))
            {
                throw new Exception("File path could not empty.");
            }

            if (!File.Exists(filePath))
            {
                throw new Exception(String.Format("Could not find a {0}.", filePath));
            }

            Assembly assembly = null;
            try
            {
                assembly = Assembly.LoadFrom(filePath);
                return assembly.ImageRuntimeVersion;
            }
            catch (Exception ex)
            {
                throw new Exception("Could not find out .Net Framework CLR Version.", ex);
            }
        }
    }
}
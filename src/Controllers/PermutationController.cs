using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace RestWebApplication1.Controllers
{
    [ApiController]
    [Route("api/arePermutation")]
    public class PermutationController : ControllerBase
    {
        //GET arePermutation
        [HttpGet(Name = "ArePermutation")]
        public async Task<string> CheckPermutation(string str1, string str2)
        {
            var result = await ArePermutation(str1, str2);
            return result;
        }

        /* function to check whether two strings are
         Permutation of each other */
        static async Task<string> ArePermutation(string str1, string str2)
        {
            try
            {

                // Get lengths of both strings
                int n1 = str1.Length;
                int n2 = str2.Length;

                // If length of both strings is not equal, then they cannot be Permutation
                if (n1 != n2)
                    return "No";

                char[] ch1 = str1.ToCharArray();
                char[] ch2 = str2.ToCharArray();

                // Sort both strings
                Array.Sort(ch1);
                Array.Sort(ch2);

                // Compare sorted strings
                for (int i = 0; i < n1; i++)
                    //if not match 
                    if (ch1[i] != ch2[i])
                        return "No";

                return "Yes";
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                throw;
            }
        }
    }
}
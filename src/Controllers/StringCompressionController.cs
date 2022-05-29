using System;
using Microsoft.AspNetCore.Mvc;

namespace RestWebApplication1.Controllers
{
    [ApiController]
    [Route("api/stringCompress")]
    public class StringCompressionController : ControllerBase
    {
        // GET: api/stringCompress/{string}
        [HttpGet("{strIn}", Name = "StringCompress")]
        public async Task<string> StringCompress(string strIn)
        {
            var result = await stringCompress(strIn);
            return result;
        }

        /* function basic string compression using the counts of repeated characters */
        static async Task<String> stringCompress(string strIn)
        {
            try
            {
                var inCount = strIn.Length;
                var strOut = "";

                //check if only 1 character, just simply add 1
                if (inCount == 1)
                {
                    strOut = strIn + "1";
                }
                else
                {
                    for (int i = 0; i < inCount; i++)
                    {
                        var lCount = 1;
                        while (i < inCount - 1 && strIn[i] == strIn[i + 1])
                        {
                            lCount++;
                            i++;
                        }
                        strOut = strOut + strIn[i].ToString() + lCount.ToString();
                    }
                }

                //check if the length of the output become smaller than the input, if not just return the input string
                if (strOut.Length >= inCount)
                {
                    strOut = strIn;
                }

                return strOut;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                throw;
            }

        }

    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PreventXSS {
    public class Security {

        string testText = "<b>hello</b><script>evil</script>";
        public string SanitizeHTML(string text, string safetags) {


            string toReplace = @"<script>|<?/script>";
            string replaceWith = @"&lt;script&gt;";

            string postSanitize = Regex.Replace(text, toReplace, replaceWith);

            return postSanitize;


            //    foreach (Match m in Regex.Matches(text, safetags)) {

            //    }
            //    text.Replace("<", "&lt");
            //    text.Replace(">", "&gt");
            //    return text;
            //}

        }
    }
}

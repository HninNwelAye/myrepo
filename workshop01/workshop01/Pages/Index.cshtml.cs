using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace workshop01.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string RandonInfo{ get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string[] data = {  "Logic will get you from A to B. Imagination will take you everywhere."
                                ,"There are 10 kinds of people. Those who know binary and those who don't."
                                ,"There are two ways of constructing a software design. One way is to make it so simple that there are obviously no deficiencies and the other is to make it so complicated that there are no obvious deficiencies."
                                ,"It's not that I'm so smart, it's just that I stay with problems longer."
                                ,"It is pitch dark. You are likely to be eaten by a grue."};
            Random random = new Random();
            int index = random.Next(data.Length);
            RandonInfo = data[index];
        }
    }
}

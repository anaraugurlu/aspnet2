using aspnet2.Entities;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aspnet2.TagHelpers
{
    [HtmlTargetElement("person-list")]
    public class PersonListTagHelper : TagHelper
    {
        private List<Person> _persons;
        public PersonListTagHelper()
        {
            _persons = new List<Person>
        {
          new Person{Name="user1",ImageUrl="1.png"},
          new Person{Name="user2",ImageUrl="2.jpg"},
          new Person{Name="user2",ImageUrl="3.png"},
        };
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            var query = _persons;
            base.Process(context, output);
            var sb = new StringBuilder();
            foreach (var item in query)
            {
                sb.AppendFormat("<h2><a href='person/detail/{0}'>{1}</a></h2>", item.Name, item.Name);
            }
            output.Content.SetHtmlContent(sb.ToString());
            base.Process(context, output);
        }

    }
}

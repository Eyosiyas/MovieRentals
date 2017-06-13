using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRentals.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Birth Date")]
        [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Is Subscribed To Newsletter")]
        public bool IsSubscribedToNewsletter { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        public MembershipType MembershipType { get; set; }
    }

    //public static class LtsCustom
    //{
    //    public static MvcHtmlString ListBox(string id, SelectList list, string headerTitle = "[Untitled]", int height = 350, object htmAttributes = null)
    //    {
    //        var builder = new TagBuilder("div");
    //        builder.GenerateId(id);
    //        builder.Attributes["name"] = "customlistbox";

    //        //header
    //        var header = new TagBuilder("div");
    //        header.AddCssClass("list-group-item nav-header push-content-opposite-ends");

    //        header.Attributes["style"] = "background-color:#EEEEEE";
    //        header.InnerHtml = "<label>" + headerTitle + "</label><span><i class='glyphicon glyphicon-plus - sign'></i></span>";
    //        //body
    //        var body = new TagBuilder("ul");

    //        body.AddCssClass("list-group list-group-hover");
    //        body.Attributes["style"] = "overflow-y:auto;height=" + height + ";";
    //        //the list
    //        if (list != null && list.Any())
    //        {
    //            string li = "";
    //            foreach (var i in list)
    //            {
    //                li += "<li class='list-group-item'><input type='hidden' value='" + i.Value + "'>" + i.Text + "</li>";
    //            }
    //            body.InnerHtml = li;
    //        }

    //        builder.InnerHtml = $"{header.ToString()}{body.ToString()}";

    //        if (htmAttributes != null) builder.MergeAttributes(new RouteValueDictionary(htmAttributes));
    //        return new MvcHtmlString(builder.ToString());
    //    }
    //}
}
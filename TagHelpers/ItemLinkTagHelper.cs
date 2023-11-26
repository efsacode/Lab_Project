﻿namespace Application1.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

[HtmlTargetElement("item-link", Attributes = "controller-name,action-name,item-id,display-text")]


public class ItemLinkTagHelper : TagHelper
{
    public string ControllerName { get; set; }
    public string ActionName { get; set; }
    public int ItemId { get; set; }
    public string DisplayText { get; set; }



    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "a";
        output.Attributes.SetAttribute("href", $"/{ControllerName}/{ActionName}/{ItemId}");
        output.Content.SetContent(DisplayText);
    }
}

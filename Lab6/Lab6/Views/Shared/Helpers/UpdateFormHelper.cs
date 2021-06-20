//using JSON_dll;
using SQL_dll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab6.Views.Shared.Helpers
{
    public static class UpdateFormHelper
    {
        public static MvcHtmlString UpdateForm(this HtmlHelper html, List<Note> phoneDictionary, Note selectedRecord)
        {
            TagBuilder form = new TagBuilder("form");
            form.AddCssClass("update-form");
            form.MergeAttribute("method", "POST");
            form.MergeAttribute("action", "/Notes/UpdateSave");

            TagBuilder linkList = new TagBuilder("div");
            linkList.AddCssClass("link-list");
            foreach (var record in phoneDictionary)
            {
                TagBuilder div = new TagBuilder("div");
                TagBuilder spanName = new TagBuilder("span");
                spanName.SetInnerText(record.Fullname + " ");
                TagBuilder spanPhone = new TagBuilder("span");
                spanPhone.SetInnerText(record.Telephone);
                div.InnerHtml += spanName;
                div.InnerHtml += spanPhone;
                linkList.InnerHtml += div;
            }

            TagBuilder inputForm = new TagBuilder("div");
            inputForm.AddCssClass("input-form");
            TagBuilder inputRecordID = new TagBuilder("input");
            inputRecordID.MergeAttribute("id", "NoteId");
            inputRecordID.MergeAttribute("name", "NoteId");
            inputRecordID.MergeAttribute("type", "text");
            inputRecordID.MergeAttribute("value", selectedRecord.NoteId.ToString());
            inputRecordID.MergeAttribute("hidden", "true");
            TagBuilder inputName = new TagBuilder("input");
            inputName.MergeAttribute("id", "Fullname");
            inputName.MergeAttribute("name", "Fullname");
            inputName.MergeAttribute("type", "text");
            inputName.MergeAttribute("value", selectedRecord.Fullname);
            TagBuilder inputPhone = new TagBuilder("input");
            inputPhone.MergeAttribute("id", "Telephone");
            inputPhone.MergeAttribute("name", "Telephone");
            inputPhone.MergeAttribute("type", "text");
            inputPhone.MergeAttribute("value", selectedRecord.Telephone);
            inputForm.InnerHtml += inputRecordID;
            inputForm.InnerHtml += inputName;
            inputForm.InnerHtml += inputPhone;

            TagBuilder secondDiv = new TagBuilder("div");
            TagBuilder inputButton = new TagBuilder("input");
            inputButton.AddCssClass("link-button");
            inputButton.MergeAttribute("id", "update_button");
            inputButton.MergeAttribute("value", "Изменить");
            inputButton.MergeAttribute("type", "submit");
            TagBuilder anchor = new TagBuilder("a");
            anchor.AddCssClass("cancel-link");
            anchor.MergeAttribute("href", "/Notes/Index");
            anchor.SetInnerText("Отказаться");
            secondDiv.InnerHtml += inputButton;
            secondDiv.InnerHtml += anchor;

            form.InnerHtml += linkList;
            form.InnerHtml += inputForm;
            form.InnerHtml += secondDiv;

            return MvcHtmlString.Create(form.ToString());
        }
    }
}
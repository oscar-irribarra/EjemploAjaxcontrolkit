using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AjaxControlToolkit.HTMLEditor;

namespace TallerAjax.modeloeditor
{
    public class editorsimple : Editor
    {
            protected override void FillTopToolbar()
            {
                TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.Bold());
                TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.Italic());
                TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.Underline());
                TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.StrikeThrough());
                TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.ForeColor());
                TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.RemoveStyles());
            
                
                TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.JustifyFull());
                TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.JustifyLeft());
                TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.JustifyCenter());
                TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.JustifyRight());

                

                TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.OrderedList());
                TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.BulletedList());

            AjaxControlToolkit.HTMLEditor.ToolbarButton.FontSize MyFontSize = new AjaxControlToolkit.HTMLEditor.ToolbarButton.FontSize();
            TopToolbar.Buttons.Add(MyFontSize);
            AjaxControlToolkit.HTMLEditor.ToolbarButton.SelectOption fontsizeOptions = new AjaxControlToolkit.HTMLEditor.ToolbarButton.SelectOption();

            fontsizeOptions.Value = "10.5px";
            fontsizeOptions.Text = "1";
            MyFontSize.Options.Add(fontsizeOptions);

            fontsizeOptions = new AjaxControlToolkit.HTMLEditor.ToolbarButton.SelectOption();
            fontsizeOptions.Value = "13.0px";
            fontsizeOptions.Text = "2";
            MyFontSize.Options.Add(fontsizeOptions);

            fontsizeOptions = new AjaxControlToolkit.HTMLEditor.ToolbarButton.SelectOption();
            fontsizeOptions.Value = "15.5px";
            fontsizeOptions.Text = "3";
            MyFontSize.Options.Add(fontsizeOptions);

            fontsizeOptions = new AjaxControlToolkit.HTMLEditor.ToolbarButton.SelectOption();
            fontsizeOptions.Value = "17.5px";
            fontsizeOptions.Text = "4";
            MyFontSize.Options.Add(fontsizeOptions);

            fontsizeOptions = new AjaxControlToolkit.HTMLEditor.ToolbarButton.SelectOption();
            fontsizeOptions.Value = "23.5px";
            fontsizeOptions.Text = "5";
            MyFontSize.Options.Add(fontsizeOptions);

        }


            protected override void FillBottomToolbar()
            {
                BottomToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.DesignMode());
                BottomToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.PreviewMode());
                BottomToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.Redo());
                BottomToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.Undo());
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace DynamicLoadWebUserControl
{
    public class Class1
    {
        public TemplateControl uc;
        public Class1 LoadUserControl(int Type)
        {
            //類別中以UserControl這個類別來載入Web User Control
            System.Web.UI.UserControl tmp0 = new System.Web.UI.UserControl();
            if (Type == 1)
            {
                uc = (UserControl.WebUserControl4)tmp0.LoadControl("~/UserControl/WebUserControl4.ascx");
            }
            else
            {
                uc = (UserControl.WebUserControl3)tmp0.LoadControl("~/UserControl/WebUserControl3.ascx");
            }
            return this;
        }
    }
}
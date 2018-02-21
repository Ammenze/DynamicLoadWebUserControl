using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DynamicLoadWebUserControl
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //以路徑在頁面直接呼叫LoadControly載入Web User Control
                UserControl.WebUserControl1 uc = (UserControl.WebUserControl1)LoadControl("~/UserControl/WebUserControl1.ascx");
                this.Panel1.Controls.Add(uc);
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //多個Web User Control以TemplateControl來載入
            TemplateControl uc;
            if (DropDownList1.SelectedIndex == 1)
            {
                uc = (UserControl.WebUserControl2)LoadControl("~/UserControl/WebUserControl2.ascx");
            }
            else
            {
                uc = (UserControl.WebUserControl1)LoadControl("~/UserControl/WebUserControl1.ascx");
            }
            this.Panel1.Controls.Add(uc);
        }
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //由外部類別取得要顯示的Web User Control來顯示
            Class1 c = new Class1().LoadUserControl(DropDownList2.SelectedIndex);
            this.Panel1.Controls.Add(c.uc);
        }
    }
}
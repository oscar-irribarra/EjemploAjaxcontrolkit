﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TallerAjax
{
    public partial class editor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnmostrar_Click(object sender, EventArgs e)
        {
            lbmostrar.Text = Editorsimple1.Content;
        }
    }
   
}
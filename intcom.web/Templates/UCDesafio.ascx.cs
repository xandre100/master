using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace intcom.web.Templates
{
    public partial class UCDesafio : System.Web.UI.UserControl
    {

        #region propriedades

        intcom.web.Services.IntcomServices _services;

        #endregion

        #region eventos

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                startTests();
            }
        }

        #endregion

        #region metodos privados

        private void startTests()
        {
            //upload();
            getAll();            
        }

        private void getAll()
        {
            _services = new Services.IntcomServices();
            object arquivos = _services.getAll();
        }

        private void upload()
        {
            _services = new Services.IntcomServices();
            string path = System.AppDomain.CurrentDomain.BaseDirectory;
            string[] files = System.IO.Directory.GetFiles(string.Format("{0}arquivos\\", path));

            _services.upload(files);
        }

        #endregion
    }
}
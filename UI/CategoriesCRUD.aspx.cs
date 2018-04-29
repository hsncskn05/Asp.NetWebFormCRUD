using BLL.Repostories;
using Model_Entity_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class CategoriesCRUD : System.Web.UI.Page
    {
        List<Category> CategoriesList;
        CategoryManagementBLL _categoryManagementBLL = new CategoryManagementBLL();
        int refreshTime = 3;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                
                RefreshDataSource();
             
            }

            
        }

        private void RefreshDataSource()
        {
            CategoriesList = _categoryManagementBLL.ListCategories();
            ddlCategories.DataSource = CategoriesList;
            ddlCategories.DataTextField = "CategoryName";
            ddlCategories.DataValueField = "CategoryID";
            ddlCategories.DataBind();
            txtCategoryName.Text = string.Empty;
            txtDescription.Text = string.Empty;
        }

        protected void ddlCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
           Category kategori=_categoryManagementBLL.GetByID(Convert.ToInt32(ddlCategories.SelectedValue));
           txtCategoryName.Text = kategori.CategoryName;
           txtDescription.Text = kategori.Description;
       
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Category yenikategori = new Category();
            yenikategori.CategoryName = txtCategoryName.Text;
            yenikategori.Description = txtDescription.Text;
            _categoryManagementBLL.AddCategory(yenikategori);
            RefreshDataSource();
            Literal1.Text = "<h1>Ekleme Başarılı</h1>";
            RefreshPage(refreshTime);
        }

        private void RefreshPage(int second)
        {
            HtmlMeta meta = new HtmlMeta();
            meta.HttpEquiv = "Refresh";
            meta.Content=second+";url=CategoriesCRUD.aspx";
            this.Page.Controls.Add(meta);
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Category güncellenecekKategori = _categoryManagementBLL.GetByID(Convert.ToInt32( ddlCategories.SelectedValue));
            güncellenecekKategori.CategoryName = txtCategoryName.Text;
            güncellenecekKategori.Description = txtDescription.Text;
            _categoryManagementBLL.UpdateCategory(güncellenecekKategori);
            RefreshDataSource();
            Literal1.Text = "<h1>Güncelleme Başarılı</h1>";
            RefreshPage(refreshTime);
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            Category silinecekKategori = _categoryManagementBLL.GetByID(Convert.ToInt32(ddlCategories.SelectedValue));
            _categoryManagementBLL.RemoveCategory(silinecekKategori);
            RefreshDataSource();
            Literal1.Text = "<h1>Silme Başarılı</h1>";
            RefreshPage(refreshTime);

        }
    }
}
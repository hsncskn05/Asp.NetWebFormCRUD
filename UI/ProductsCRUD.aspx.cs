using BLL.Repostories;
using Model_Entity_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class ProductsCRUD : System.Web.UI.Page
    {
        List<Product> ProductsList;
        ProductManagementBLL _productManagementBLL = new ProductManagementBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                RefreshDataSource();

            }

        }
        private void RefreshDataSource()
        {
            ProductsList = _productManagementBLL.ListProducts();
            ddlProducts.DataSource = ProductsList;
            ddlProducts.DataTextField = "ProductName";
            ddlProducts.DataValueField = "ProductID";
            ddlProducts.DataBind();
            txtProduct.Text = string.Empty;
            txtDiscontinued.Text = string.Empty;
          
        }

        protected void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Product ürün = _productManagementBLL.GetByID(Convert.ToInt32(ddlProducts.SelectedValue));
            txtProduct.Text = ürün.ProductName;
            txtDiscontinued.Text = ürün.Discontinued.ToString();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Product yeniürün = new Product();
            yeniürün.ProductName = txtProduct.Text;
            yeniürün.Discontinued =Convert.ToBoolean (txtDiscontinued.Text);
            _productManagementBLL.AddProduct(yeniürün);
             RefreshDataSource();
             Literal1.Text = "<h1>Ekleme Başarılı</h1>";
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
         

            Product silinecekÜrün = _productManagementBLL.GetByID(Convert.ToInt32(ddlProducts.SelectedValue));
            _productManagementBLL.RemoveProduct(silinecekÜrün);
            RefreshDataSource();
            Literal1.Text = "<h1>Silme Başarılı</h1>";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Product güncellenecekUrun = _productManagementBLL.GetByID(Convert.ToInt32(ddlProducts.SelectedValue));
            güncellenecekUrun.ProductName = txtProduct.Text;
            güncellenecekUrun.Discontinued =Convert.ToBoolean( txtDiscontinued.Text);
            _productManagementBLL.UpdateProduct(güncellenecekUrun);
            RefreshDataSource();
            Literal1.Text = "<h1>Güncelleme Başarılı</h1>";


        }
    }
}
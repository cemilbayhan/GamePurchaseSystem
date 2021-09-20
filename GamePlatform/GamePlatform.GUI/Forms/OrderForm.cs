using GamePlatform.Business.Repository.Concrete;
using GamePlatform.Entities;
using GamePlatform.GUI.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamePlatform.GUI.Forms
{
    public partial class OrderForm : Form
    {
        OrderManagement orderManagement = new OrderManagement();


        public OrderForm()
        {
            InitializeComponent();
        }

        private void List()
        {
            dgvBuyGame.DataSource = orderManagement.GetGames();
        }


        private void OrderForm_Load_1(object sender, EventArgs e)
        {
            List();
        }


        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Satın alınacak. Emin misiniz?", "Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txtOrderID.Text != null)
                {
                    int orderID = Convert.ToInt32(txtOrderID.Text);
                    int couponID = Convert.ToInt32(txtCouponID.Text);
                    var order = orderManagement.Get(x => x.OrderID == orderID);
                    var coupon = orderManagement.GetCoupon(x => x.CouponID == couponID);
                    decimal? discountFee= 0, totalPrice = 0;
                    int? discountPercentage = 0;

                    if (!String.IsNullOrEmpty(txtCouponID.Text))
                    {
                        if (coupon.DiscountFee != null)
                        {
                            discountFee = coupon.DiscountFee;
                            totalPrice = order.Price - discountFee;
                        }
                        else if (coupon.DiscountPercentage != null) {
                            discountPercentage = coupon.DiscountPercentage;
                            totalPrice = order.Price - (discountPercentage * order.Price / 100);
                        }
                            
                    }
                    else
                        totalPrice = order.Price;


                        Order_Game order_Game = new Order_Game()
                        {
                            OrderGameID = order.OrderID,
                            CustomerID = User._loggedUser.CustomerID,
                            PaymentDate = DateTime.Now,
                            UploadOnDesktop = "N",
                            Price = totalPrice,
                            CouponID = couponID
                        };
                    

                    orderManagement.AddOrderGame(order_Game);
                    
                }
            }
            
        }

        private void dgvBuyGame_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dgvBuyGame.Rows[e.RowIndex];
            txtOrderID.Text = selectedRow.Cells["OrderID"].Value.ToString();
            txtGameName.Text = selectedRow.Cells["GameName"].Value.ToString();
            txtPackageType.Text = selectedRow.Cells["PackageName"].Value.ToString();
        }
    }
}

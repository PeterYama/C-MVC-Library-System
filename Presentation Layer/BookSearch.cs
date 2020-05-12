using Business_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Presentation_Layer
{
    public partial class BookSearch : Form
    {
        DataSet dataSet;
        SearchLogic search;
        string userChoice;
        public BookSearch()
        {
            InitializeComponent();
            dataSet = new DataSet();
            this.myCombo.Items.AddRange(new object[] {
                "Title",
                "Published Year",
                "Language",
                "Author",
                "Category"});

            search = new SearchLogic();
            this.Controls.Add(resultGridView);
        }

        private void InitializeDataGridView()
        {
            userChoice = myCombo.SelectedItem.ToString();
            dataSet = search.getBooksBy(userChoice);
            resultGridView.DataSource = dataSet;
            resultGridView.DataMember = "books";

            resultGridView.DataBindingComplete += (o, _) =>
            {
                var dataGridView = o as DataGridView;
                if (dataGridView != null)
                {
                    dataGridView.BackgroundColor = Color.LightGray;
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            };

        }

        private void ComboTesst_btn_Click(object sender, EventArgs e)
        {
            InitializeDataGridView();
        }
    }

}

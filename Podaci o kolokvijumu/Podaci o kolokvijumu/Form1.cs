using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podaci_o_kolokvijumu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<ExerciseResult> lista = new List<ExerciseResult>();
            string constring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FacultyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string command = "SELECT * FROM ExercisesResults";
            SqlCommand com = new SqlCommand(command, con);
            SqlDataReader dr = com.ExecuteReader();
            while(dr.Read())
            {
                ExerciseResult temp = new ExerciseResult(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetInt32(3));
                lista.Add(temp);
            }
            foreach (ExerciseResult er in lista)
                listBox1.Items.Add(er.ToString());

        }
    }
}

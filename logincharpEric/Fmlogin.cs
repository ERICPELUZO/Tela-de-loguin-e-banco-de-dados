using System.Data.SqlClient;
namespace logincharpEric
{
    public partial class Fmlogin : Form
    {

        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-U7MAM9H;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

        public Fmlogin()
        {
            InitializeComponent();

            Text_Usuario.Select ();

        }
    }
}